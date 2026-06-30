using Microsoft.Extensions.Options;
using System.Text.Json;
using Microsoft.Extensions.Caching.Distributed;

using TraineeManagement.Api.Configurations;

namespace TraineeManagement.Api.Services;


public class RedisService : IRedisService
{

    private IDistributedCache _cache;
    private ILogger<RedisService> _logger;
    private RedisConfig _redisConfig;
    private IHttpContextAccessor _httpContextAccessor;

    public RedisService(
        IDistributedCache cache,
        ILogger<RedisService> logger,
        IOptions<RedisConfig> options,
        IHttpContextAccessor httpContextAccessor
    )
    {
        _cache = cache;
        _logger = logger;
        _redisConfig = options.Value;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<T?> GetAsync<T>(string key)
    {
        string requestId = _httpContextAccessor.HttpContext.TraceIdentifier;

        try
        {
            string? cachedData = await _cache.GetStringAsync(key);

            if (string.IsNullOrEmpty(cachedData))
            {
                _logger.LogInformation("RequestId : [{requestId}]. Cache miss for key: {Key}",requestId, key);
                return default;
            }

            _logger.LogInformation("RequestId : [{requestId}]. Cache hit for key: {Key}",requestId, key);

            return JsonSerializer.Deserialize<T>(cachedData);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "RequestId : [{requestId}]. Error retrieving key {Key} from cache", requestId, key);
            return default;
        }
    }

    public async Task SetAsync<T>(string key, T value)
    {
        string requestId = _httpContextAccessor.HttpContext.TraceIdentifier;

        try
        {
            if (value == null) {
                _logger.LogWarning($"RequestId : [{requestId}]. Error setting cache for key : {key}!! value was not provided..");
                return;
            }

            // Serialize the object to a JSON string
            string jsonData = JsonSerializer.Serialize(value);

            DistributedCacheEntryOptions cacheOptions = new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(_redisConfig.DefaultItlSeconds)
            };

            // Save to Redis 
            await _cache.SetStringAsync(key, jsonData, cacheOptions);

            _logger.LogInformation("RequestId : [{requestId}]. Successfully cached key: {Key}", requestId, key);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "RequestId : [{requestId}]. Error setting key {Key} in cache", requestId, key);
        }
    }

    public async Task RemoveAsync(string key)
    {
        string requestId = _httpContextAccessor.HttpContext.TraceIdentifier;

        try
        {
            string? cachedData = await _cache.GetStringAsync(key);

            if (string.IsNullOrEmpty(cachedData))
            {
                _logger.LogWarning("RequestId : [{requestId}]. Cache value for key: {Key} does not exist..",requestId, key);
                return;
            }

            await _cache.RemoveAsync(key);
            _logger.LogInformation("RequestId : [{requestId}]. Successfully removed key from cache: {Key}",requestId, key);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "RequestId : [{requestId}]. Error removing key {Key} from cache",requestId, key);
        }
    }
}
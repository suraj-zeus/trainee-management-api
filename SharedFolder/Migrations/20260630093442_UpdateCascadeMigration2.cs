using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharedFolder.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCascadeMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProcessingJobs_SubmissionFiles_FileId",
                table: "ProcessingJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Mentors_MentorId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Submissions_SubmissionId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_SubmissionFiles_Submissions_SubmissionId",
                table: "SubmissionFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Submissions_TaskAssignments_TaskAssignmentId",
                table: "Submissions");

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessingJobs_SubmissionFiles_FileId",
                table: "ProcessingJobs",
                column: "FileId",
                principalTable: "SubmissionFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Mentors_MentorId",
                table: "Reviews",
                column: "MentorId",
                principalTable: "Mentors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Submissions_SubmissionId",
                table: "Reviews",
                column: "SubmissionId",
                principalTable: "Submissions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubmissionFiles_Submissions_SubmissionId",
                table: "SubmissionFiles",
                column: "SubmissionId",
                principalTable: "Submissions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Submissions_TaskAssignments_TaskAssignmentId",
                table: "Submissions",
                column: "TaskAssignmentId",
                principalTable: "TaskAssignments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProcessingJobs_SubmissionFiles_FileId",
                table: "ProcessingJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Mentors_MentorId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Submissions_SubmissionId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_SubmissionFiles_Submissions_SubmissionId",
                table: "SubmissionFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Submissions_TaskAssignments_TaskAssignmentId",
                table: "Submissions");

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessingJobs_SubmissionFiles_FileId",
                table: "ProcessingJobs",
                column: "FileId",
                principalTable: "SubmissionFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Mentors_MentorId",
                table: "Reviews",
                column: "MentorId",
                principalTable: "Mentors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Submissions_SubmissionId",
                table: "Reviews",
                column: "SubmissionId",
                principalTable: "Submissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubmissionFiles_Submissions_SubmissionId",
                table: "SubmissionFiles",
                column: "SubmissionId",
                principalTable: "Submissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Submissions_TaskAssignments_TaskAssignmentId",
                table: "Submissions",
                column: "TaskAssignmentId",
                principalTable: "TaskAssignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

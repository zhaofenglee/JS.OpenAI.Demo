using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JS.OpenAI.Demo.Migrations
{
    /// <inheritdoc />
    public partial class AddedOpenAI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OpenAIConversations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Temperature = table.Column<float>(type: "REAL", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    ExtraProperties = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatorId = table.Column<Guid>(type: "TEXT", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenAIConversations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpenAIMessages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    MessageType = table.Column<int>(type: "INTEGER", nullable: false),
                    ConversationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExtraProperties = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatorId = table.Column<Guid>(type: "TEXT", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenAIMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpenAIMessages_OpenAIConversations_ConversationId",
                        column: x => x.ConversationId,
                        principalTable: "OpenAIConversations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OpenAIMessages_ConversationId",
                table: "OpenAIMessages",
                column: "ConversationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OpenAIMessages");

            migrationBuilder.DropTable(
                name: "OpenAIConversations");
        }
    }
}

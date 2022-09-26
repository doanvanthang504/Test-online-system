using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThangDV29_MiniProject_WebAPI.Migrations
{
    public partial class initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsAuthentication = table.Column<bool>(type: "bit", nullable: false),
                    IsBLock = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameExam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeExam = table.Column<int>(type: "int", nullable: true),
                    DateExam = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageQuestion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Student_Exam",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExamID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    Score = table.Column<double>(type: "float", nullable: true),
                    DateExam = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Exam", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Student_Exam_Exam",
                        column: x => x.ExamID,
                        principalTable: "Exam",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Student_Exam_Student",
                        column: x => x.StudentID,
                        principalTable: "Account",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Exam.Question",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExamID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeacherID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam.Question", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Exam.Question_Exam  ",
                        column: x => x.ExamID,
                        principalTable: "Exam",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Exam.Question_Question",
                        column: x => x.QuestionID,
                        principalTable: "Question",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Exam.Question_Teacher",
                        column: x => x.TeacherID,
                        principalTable: "Account",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "History.Exam",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateExam = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnswerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExamID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History.Exam", x => x.ID);
                    table.ForeignKey(
                        name: "FK_History.Exam_Account",
                        column: x => x.AccountID,
                        principalTable: "Account",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_History.Exam_Answer",
                        column: x => x.AnswerID,
                        principalTable: "Answer",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_History.Exam_Exam_ExamID",
                        column: x => x.ExamID,
                        principalTable: "Exam",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_History.Exam_Question",
                        column: x => x.QuestionID,
                        principalTable: "Question",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Question.Answer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnswerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResultAnswer = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question.Answer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Questions.Answer_Answer  ",
                        column: x => x.AnswerID,
                        principalTable: "Answer",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Questions.Answer_Question",
                        column: x => x.QuestionID,
                        principalTable: "Question",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "ID", "BirthDay", "DateCreate", "Email", "FullName", "IsAuthentication", "IsBLock", "PasswordHash", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("a68393ff-15fa-4136-85e2-71cdc505d8e8"), new DateTime(1999, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 14, 9, 50, 50, 0, DateTimeKind.Unspecified), "doanvanthang504@gmail.com", "DOAN VAN THANG", true, false, "$2a$11$Gm8thijPpzN91gocsw4CWuAF7E8E7m2SDaz6f8Go.XI5UQ/TmI/OC", 0, "doanvanthang504" },
                    { new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b"), new DateTime(1998, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 14, 9, 50, 50, 0, DateTimeKind.Unspecified), "lethihoa99@gmail.com", "LE THI HOA", true, false, "$2a$11$UHdHCIOthFp0T6/6TUP22uUv3LZDbku6vK/9jGgYdhS033zECmi1W", 1, "lethihoa99" },
                    { new Guid("23e22ae9-c14a-4e5d-8bf0-e4734143ed41"), new DateTime(1988, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 14, 9, 50, 50, 0, DateTimeKind.Unspecified), "taolagiaovien@gmail.com", "tao la giao vien", true, false, "$2a$11$ZN4Q/qgtpUkjTvDawVoD6e3PSO0QVjdGEQt3nNKpCwmxez/hrCIxi", 1, "giaovien" },
                    { new Guid("e280d537-732c-465a-ab22-74d4cbb696c2"), new DateTime(1988, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 14, 9, 50, 51, 0, DateTimeKind.Unspecified), "taolagiaovien22@gmail.com", "tao la giao vien 22", true, false, "$2a$11$Wzbq.tZjQB9kTzBedk71LedJHtufgcw7NBFHKyXT127cfjO9tkoLi", 1, "giaovien2" },
                    { new Guid("9c7b60b6-44b6-4a6f-9c4b-a0ece4672421"), new DateTime(2000, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 14, 9, 50, 51, 0, DateTimeKind.Unspecified), "nguyenvananh123@gmail.com", "NGUYEN VAN ANH", false, false, "$2a$11$gsJg8xBacEOlZzeBEwhvOuG76ZsYW1gHutdHDYp9nZQ7WfWr9r/HO", 2, "nguyenvananh123" },
                    { new Guid("a277d8ae-df9e-4259-909b-a7c790b9389a"), new DateTime(2000, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 14, 9, 50, 51, 0, DateTimeKind.Unspecified), "duonganhhong98@gmail.com", "DUONG ANH HONG", false, false, "$2a$11$JwD6gTtAjtopv1nkvy6LBO0qF3.WiidDqWB5caeTv3W0bkKMD6AU2", 2, "duonganhhong98" },
                    { new Guid("a177d8ae-df9e-4259-909b-a7c790b9389a"), new DateTime(2000, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 14, 9, 50, 51, 0, DateTimeKind.Unspecified), "lekhanhhoa@gmail.com", "Le Khanh Hoa", false, false, "$2a$11$iy8RBb2no71OlZB0FXjc1uSxitSWapyVbgeKUCY4I61nTzSntlJve", 2, "lekhanhhoa" },
                    { new Guid("a377d8ae-df9e-4259-909b-a7c790b9389a"), new DateTime(2000, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 14, 9, 50, 52, 0, DateTimeKind.Unspecified), "bao123@gmail.com", "Pham Tran Huy Bao", false, false, "$2a$11$2tsbAB76buChrpAWtQQCZePj8hybq08.afLy026q/k7erzQ/RAnv2", 2, "phamtranhuybao123" },
                    { new Guid("a477d8ae-df9e-4259-909b-a7c790b9389a"), new DateTime(2000, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 14, 9, 50, 52, 0, DateTimeKind.Unspecified), "duyduyduy@gmail.com", "Van Duy", false, false, "$2a$11$8xdB5b8Tfurz1UIDrPtPlOB6cqcdwkcRUzxSJcxgjNqDDnD/G3qnC", 2, "duyduyduy1" }
                });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "ID", "DescriptionAnswer", "ImageAnswer" },
                values: new object[,]
                {
                    { new Guid("44ef4b9f-217e-4477-9877-98e7fe9bdd6f"), "ccccccccc", "www.image6" },
                    { new Guid("d10af90d-d41d-4b15-821a-9b928b3b7940"), "bbbbbbb", "www.image6" },
                    { new Guid("c3b8f3db-e1cb-4af4-b51d-fbe23c826e54"), "aaaaaaaa", "www.image6" },
                    { new Guid("2f084f72-0692-43ee-8b0f-15644fcef973"), "chon cau a", "www.image6" },
                    { new Guid("35c5e7a7-3176-42fc-8d1b-347809614b90"), "thoi dep me di", "www.image6" },
                    { new Guid("f19beebe-16a5-492e-9197-2ed7ee51effc"), "chon cau d", "www.image6" },
                    { new Guid("8f5be11b-caf1-4a63-9121-0b8b3668fb5d"), "di hoi thang khac di", "www.image4" },
                    { new Guid("6687b5b9-a407-4f34-88af-ef10b58fffc9"), "tao thua", "www.image3" },
                    { new Guid("ec0983cf-316c-4a00-9ea0-9aa5e8a1b44f"), "dung hoi tao", "www.image2" },
                    { new Guid("ce6882a5-7e2d-4ec0-85c8-c9fc96998da7"), "tao khong biet", "www.image1" },
                    { new Guid("2d9fa7e8-420f-45b9-99e4-031fa241d1b6"), "de tra google", "www.image5" }
                });

            migrationBuilder.InsertData(
                table: "Exam",
                columns: new[] { "ID", "DateExam", "NameExam", "TimeExam" },
                values: new object[,]
                {
                    { new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"), new DateTime(2022, 6, 14, 16, 50, 52, 341, DateTimeKind.Local).AddTicks(3035), "De de vai lon", 90 },
                    { new Guid("b22cea50-b2e1-4467-91a0-7e96fccc9b1d"), new DateTime(2022, 6, 14, 16, 50, 52, 341, DateTimeKind.Local).AddTicks(3431), "code 180 phut", 180 },
                    { new Guid("b32cea50-b2e1-4467-91a0-7e96fccc9b1d"), new DateTime(2022, 6, 14, 16, 50, 52, 341, DateTimeKind.Local).AddTicks(3442), "code thoi dung xam lol", 70 }
                });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "ID", "ImageQuestion", "NameQuestion" },
                values: new object[,]
                {
                    { new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b7d"), "www.image6 ", "Ai dep chai nhat" },
                    { new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b6d"), "www.image6 ", "Con gi khong biet boi" },
                    { new Guid("b42cea50-b2e1-4467-91a0-7e96facc9b6d"), "www.image6 ", "Con chim mau gi" },
                    { new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b5d"), "www.image5 ", "Con chim co may chan" },
                    { new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b1d"), "www.image1 ", "Con heo co may chan" },
                    { new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b3d"), "www.image3 ", "Con ga co may chan" },
                    { new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b2d"), "www.image2 ", "Con cho co may chan" },
                    { new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b8d"), "www.image6 ", "Bao cham bao nhieu diem" },
                    { new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b4d"), "www.imag4 ", "Con gan co may chan" },
                    { new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b9d"), "www.image6 ", "Code tao co sach khong" }
                });

            migrationBuilder.InsertData(
                table: "Exam.Question",
                columns: new[] { "ID", "ExamID", "QuestionID", "TeacherID" },
                values: new object[,]
                {
                    { new Guid("1d8351ab-82dd-436b-a699-cadcaa7dfbe0"), new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") },
                    { new Guid("28e12f28-3e99-40c7-abb0-400d20bc6d42"), new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b2d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") },
                    { new Guid("dab62044-a562-411f-a29b-915457fb334b"), new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b3d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") },
                    { new Guid("c34fd4f4-96e8-4fa4-9267-5d575931724d"), new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b4d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") },
                    { new Guid("9ab172d2-f2c0-485d-bc5d-2f666714e2e7"), new Guid("b22cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b4d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") },
                    { new Guid("f1352baf-cbc3-4f8c-8bd8-ef291e3b391b"), new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b5d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") },
                    { new Guid("4eb78c04-6841-4ccd-88ca-a243150d59ed"), new Guid("b32cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b5d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") },
                    { new Guid("9e9d3b27-9450-4b28-8ce2-b802fa45f734"), new Guid("b22cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96facc9b6d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") }
                });

            migrationBuilder.InsertData(
                table: "Student_Exam",
                columns: new[] { "ID", "DateExam", "ExamID", "Score", "Status", "StudentID" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 14, 9, 50, 52, 343, DateTimeKind.Utc).AddTicks(820), new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"), 7.7999999999999998, true, new Guid("9c7b60b6-44b6-4a6f-9c4b-a0ece4672421") },
                    { 4, new DateTime(2022, 6, 14, 9, 50, 52, 343, DateTimeKind.Utc).AddTicks(2546), new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"), 8.5, true, new Guid("a377d8ae-df9e-4259-909b-a7c790b9389a") },
                    { 8, new DateTime(2022, 6, 14, 9, 50, 52, 343, DateTimeKind.Utc).AddTicks(2572), new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"), 8.6999999999999993, true, new Guid("a277d8ae-df9e-4259-909b-a7c790b9389a") },
                    { 2, new DateTime(2022, 6, 14, 9, 50, 52, 343, DateTimeKind.Utc).AddTicks(2528), new Guid("b22cea50-b2e1-4467-91a0-7e96fccc9b1d"), 9.5, true, new Guid("a277d8ae-df9e-4259-909b-a7c790b9389a") },
                    { 5, new DateTime(2022, 6, 14, 9, 50, 52, 343, DateTimeKind.Utc).AddTicks(2552), new Guid("b22cea50-b2e1-4467-91a0-7e96fccc9b1d"), 6.0, true, new Guid("a477d8ae-df9e-4259-909b-a7c790b9389a") },
                    { 7, new DateTime(2022, 6, 14, 9, 50, 52, 343, DateTimeKind.Utc).AddTicks(2567), new Guid("b22cea50-b2e1-4467-91a0-7e96fccc9b1d"), 9.0999999999999996, true, new Guid("a177d8ae-df9e-4259-909b-a7c790b9389a") },
                    { 3, new DateTime(2022, 6, 14, 9, 50, 52, 343, DateTimeKind.Utc).AddTicks(2539), new Guid("b32cea50-b2e1-4467-91a0-7e96fccc9b1d"), 4.0, false, new Guid("a177d8ae-df9e-4259-909b-a7c790b9389a") },
                    { 6, new DateTime(2022, 6, 14, 9, 50, 52, 343, DateTimeKind.Utc).AddTicks(2562), new Guid("b32cea50-b2e1-4467-91a0-7e96fccc9b1d"), 6.7000000000000002, true, new Guid("a377d8ae-df9e-4259-909b-a7c790b9389a") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_Email",
                table: "Account",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Account_Username",
                table: "Account",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Exam.Question_ExamID",
                table: "Exam.Question",
                column: "ExamID");

            migrationBuilder.CreateIndex(
                name: "IX_Exam.Question_QuestionID",
                table: "Exam.Question",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_Exam.Question_TeacherID",
                table: "Exam.Question",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_History.Exam_AccountID",
                table: "History.Exam",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_History.Exam_AnswerID",
                table: "History.Exam",
                column: "AnswerID");

            migrationBuilder.CreateIndex(
                name: "IX_History.Exam_ExamID",
                table: "History.Exam",
                column: "ExamID");

            migrationBuilder.CreateIndex(
                name: "IX_History.Exam_QuestionID",
                table: "History.Exam",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_Question.Answer_AnswerID",
                table: "Question.Answer",
                column: "AnswerID");

            migrationBuilder.CreateIndex(
                name: "IX_Question.Answer_QuestionID",
                table: "Question.Answer",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Exam_ExamID",
                table: "Student_Exam",
                column: "ExamID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Exam_StudentID",
                table: "Student_Exam",
                column: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exam.Question");

            migrationBuilder.DropTable(
                name: "History.Exam");

            migrationBuilder.DropTable(
                name: "Question.Answer");

            migrationBuilder.DropTable(
                name: "Student_Exam");

            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.DropTable(
                name: "Account");
        }
    }
}

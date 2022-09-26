using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThangDV29_MiniProject_WebAPI.Migrations
{
    public partial class updateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exam.Question",
                keyColumn: "ID",
                keyValue: new Guid("1d8351ab-82dd-436b-a699-cadcaa7dfbe0"));

            migrationBuilder.DeleteData(
                table: "Exam.Question",
                keyColumn: "ID",
                keyValue: new Guid("28e12f28-3e99-40c7-abb0-400d20bc6d42"));

            migrationBuilder.DeleteData(
                table: "Exam.Question",
                keyColumn: "ID",
                keyValue: new Guid("4eb78c04-6841-4ccd-88ca-a243150d59ed"));

            migrationBuilder.DeleteData(
                table: "Exam.Question",
                keyColumn: "ID",
                keyValue: new Guid("9ab172d2-f2c0-485d-bc5d-2f666714e2e7"));

            migrationBuilder.DeleteData(
                table: "Exam.Question",
                keyColumn: "ID",
                keyValue: new Guid("9e9d3b27-9450-4b28-8ce2-b802fa45f734"));

            migrationBuilder.DeleteData(
                table: "Exam.Question",
                keyColumn: "ID",
                keyValue: new Guid("c34fd4f4-96e8-4fa4-9267-5d575931724d"));

            migrationBuilder.DeleteData(
                table: "Exam.Question",
                keyColumn: "ID",
                keyValue: new Guid("dab62044-a562-411f-a29b-915457fb334b"));

            migrationBuilder.DeleteData(
                table: "Exam.Question",
                keyColumn: "ID",
                keyValue: new Guid("f1352baf-cbc3-4f8c-8bd8-ef291e3b391b"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "ID",
                keyValue: new Guid("23e22ae9-c14a-4e5d-8bf0-e4734143ed41"),
                columns: new[] { "DateCreate", "PasswordHash" },
                values: new object[] { new DateTime(2022, 6, 14, 10, 0, 13, 0, DateTimeKind.Unspecified), "$2a$11$BypCuVlOrP/xpGygZGZ5AOkjZAaaalBcON2dIwvaBtPsetiW08bVG" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "ID",
                keyValue: new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b"),
                columns: new[] { "DateCreate", "PasswordHash" },
                values: new object[] { new DateTime(2022, 6, 14, 10, 0, 13, 0, DateTimeKind.Unspecified), "$2a$11$I1YEMWSyYmlPXdgIIbPPQOBUbymIEy5VFQ.8k7yfkgSycdReiLTQm" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "ID",
                keyValue: new Guid("9c7b60b6-44b6-4a6f-9c4b-a0ece4672421"),
                columns: new[] { "DateCreate", "PasswordHash" },
                values: new object[] { new DateTime(2022, 6, 14, 10, 0, 13, 0, DateTimeKind.Unspecified), "$2a$11$5tBeQ7.N/H3XHsrpBnUuZ.WQCHWXuyGRsBiZP..9tn0DNJ6Sxddzy" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "ID",
                keyValue: new Guid("a177d8ae-df9e-4259-909b-a7c790b9389a"),
                columns: new[] { "DateCreate", "PasswordHash" },
                values: new object[] { new DateTime(2022, 6, 14, 10, 0, 14, 0, DateTimeKind.Unspecified), "$2a$11$w.5QYhJWxHy43hRR8pxX5uqnxUlB/cZ9V..I47u8zEUTAzJuD/A0a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "ID",
                keyValue: new Guid("a277d8ae-df9e-4259-909b-a7c790b9389a"),
                columns: new[] { "DateCreate", "PasswordHash" },
                values: new object[] { new DateTime(2022, 6, 14, 10, 0, 14, 0, DateTimeKind.Unspecified), "$2a$11$et83i4WKzc1i8ONRvOcfGuigOst/CZEfhJCUChQ8bmga83iW9iELW" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "ID",
                keyValue: new Guid("a377d8ae-df9e-4259-909b-a7c790b9389a"),
                columns: new[] { "DateCreate", "PasswordHash" },
                values: new object[] { new DateTime(2022, 6, 14, 10, 0, 14, 0, DateTimeKind.Unspecified), "$2a$11$Ri723fZnkajQ8hiVBvoD2.yA/.PuO35RaWsDlNHO4mfBpBa6WjWNK" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "ID",
                keyValue: new Guid("a477d8ae-df9e-4259-909b-a7c790b9389a"),
                columns: new[] { "DateCreate", "PasswordHash" },
                values: new object[] { new DateTime(2022, 6, 14, 10, 0, 14, 0, DateTimeKind.Unspecified), "$2a$11$p9wlWXe0bIZlUYJHCreV4uC6Zf754J.BKV06.sXMm5tc0hZ2iGTe." });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "ID",
                keyValue: new Guid("a68393ff-15fa-4136-85e2-71cdc505d8e8"),
                columns: new[] { "DateCreate", "PasswordHash" },
                values: new object[] { new DateTime(2022, 6, 14, 10, 0, 12, 0, DateTimeKind.Unspecified), "$2a$11$RpJwaoF5bJSC50bOgEE/peqDRf4TQ.RZeYCmE79z6Iaz5XvatFchq" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "ID",
                keyValue: new Guid("e280d537-732c-465a-ab22-74d4cbb696c2"),
                columns: new[] { "DateCreate", "PasswordHash" },
                values: new object[] { new DateTime(2022, 6, 14, 10, 0, 13, 0, DateTimeKind.Unspecified), "$2a$11$2ZIvKnZEsbZAjo0Ime2lbepvKHD03Q71CpAiwM9O26184x2XxRRR." });

            migrationBuilder.UpdateData(
                table: "Exam",
                keyColumn: "ID",
                keyValue: new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                column: "DateExam",
                value: new DateTime(2022, 6, 14, 17, 0, 14, 584, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Exam",
                keyColumn: "ID",
                keyValue: new Guid("b22cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                column: "DateExam",
                value: new DateTime(2022, 6, 14, 17, 0, 14, 584, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Exam",
                keyColumn: "ID",
                keyValue: new Guid("b32cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                column: "DateExam",
                value: new DateTime(2022, 6, 14, 17, 0, 14, 584, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.InsertData(
                table: "Exam.Question",
                columns: new[] { "ID", "ExamID", "QuestionID", "TeacherID" },
                values: new object[,]
                {
                    { new Guid("bff7bee7-66f2-430a-beb0-1bc9179086eb"), new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") },
                    { new Guid("7c0b8461-85a7-4f70-bf6f-e6a680097bf6"), new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b5d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") },
                    { new Guid("60123723-badf-4cad-b262-ffd052e28823"), new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b2d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") },
                    { new Guid("2a9971c2-697d-4821-9d48-6b2ddc8f25d9"), new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b3d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") },
                    { new Guid("c37c7718-8773-4052-bc91-268000802107"), new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b4d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") },
                    { new Guid("55cacb3b-8389-4d32-a38e-3da340e445f2"), new Guid("b22cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96facc9b6d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") },
                    { new Guid("807f39e5-4979-436a-9bf4-feef1cb2cc92"), new Guid("b22cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b4d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") },
                    { new Guid("2afd19db-41ba-4905-98e4-9733150d4270"), new Guid("b32cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b5d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") }
                });

            migrationBuilder.InsertData(
                table: "Question.Answer",
                columns: new[] { "ID", "AnswerID", "QuestionID", "ResultAnswer" },
                values: new object[,]
                {
                    { 5, new Guid("2d9fa7e8-420f-45b9-99e4-031fa241d1b6"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b1d"), false },
                    { 6, new Guid("35c5e7a7-3176-42fc-8d1b-347809614b90"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b2d"), true },
                    { 2, new Guid("ec0983cf-316c-4a00-9ea0-9aa5e8a1b44f"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b1d"), true },
                    { 3, new Guid("6687b5b9-a407-4f34-88af-ef10b58fffc9"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b2d"), false },
                    { 4, new Guid("8f5be11b-caf1-4a63-9121-0b8b3668fb5d"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b2d"), true },
                    { 8, new Guid("f19beebe-16a5-492e-9197-2ed7ee51effc"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b2d"), false },
                    { 7, new Guid("2f084f72-0692-43ee-8b0f-15644fcef973"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b3d"), true },
                    { 1, new Guid("ce6882a5-7e2d-4ec0-85c8-c9fc96998da7"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b1d"), true }
                });

            migrationBuilder.UpdateData(
                table: "Student_Exam",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateExam",
                value: new DateTime(2022, 6, 14, 10, 0, 14, 587, DateTimeKind.Utc).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Student_Exam",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateExam",
                value: new DateTime(2022, 6, 14, 10, 0, 14, 587, DateTimeKind.Utc).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "Student_Exam",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateExam",
                value: new DateTime(2022, 6, 14, 10, 0, 14, 587, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Student_Exam",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateExam",
                value: new DateTime(2022, 6, 14, 10, 0, 14, 587, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Student_Exam",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateExam",
                value: new DateTime(2022, 6, 14, 10, 0, 14, 587, DateTimeKind.Utc).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Student_Exam",
                keyColumn: "ID",
                keyValue: 6,
                column: "DateExam",
                value: new DateTime(2022, 6, 14, 10, 0, 14, 587, DateTimeKind.Utc).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Student_Exam",
                keyColumn: "ID",
                keyValue: 7,
                column: "DateExam",
                value: new DateTime(2022, 6, 14, 10, 0, 14, 587, DateTimeKind.Utc).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Student_Exam",
                keyColumn: "ID",
                keyValue: 8,
                column: "DateExam",
                value: new DateTime(2022, 6, 14, 10, 0, 14, 587, DateTimeKind.Utc).AddTicks(3801));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exam.Question",
                keyColumn: "ID",
                keyValue: new Guid("2a9971c2-697d-4821-9d48-6b2ddc8f25d9"));

            migrationBuilder.DeleteData(
                table: "Exam.Question",
                keyColumn: "ID",
                keyValue: new Guid("2afd19db-41ba-4905-98e4-9733150d4270"));

            migrationBuilder.DeleteData(
                table: "Exam.Question",
                keyColumn: "ID",
                keyValue: new Guid("55cacb3b-8389-4d32-a38e-3da340e445f2"));

            migrationBuilder.DeleteData(
                table: "Exam.Question",
                keyColumn: "ID",
                keyValue: new Guid("60123723-badf-4cad-b262-ffd052e28823"));

            migrationBuilder.DeleteData(
                table: "Exam.Question",
                keyColumn: "ID",
                keyValue: new Guid("7c0b8461-85a7-4f70-bf6f-e6a680097bf6"));

            migrationBuilder.DeleteData(
                table: "Exam.Question",
                keyColumn: "ID",
                keyValue: new Guid("807f39e5-4979-436a-9bf4-feef1cb2cc92"));

            migrationBuilder.DeleteData(
                table: "Exam.Question",
                keyColumn: "ID",
                keyValue: new Guid("bff7bee7-66f2-430a-beb0-1bc9179086eb"));

            migrationBuilder.DeleteData(
                table: "Exam.Question",
                keyColumn: "ID",
                keyValue: new Guid("c37c7718-8773-4052-bc91-268000802107"));

            migrationBuilder.DeleteData(
                table: "Question.Answer",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Question.Answer",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Question.Answer",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Question.Answer",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Question.Answer",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Question.Answer",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Question.Answer",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Question.Answer",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "ID",
                keyValue: new Guid("23e22ae9-c14a-4e5d-8bf0-e4734143ed41"),
                columns: new[] { "DateCreate", "PasswordHash" },
                values: new object[] { new DateTime(2022, 6, 14, 9, 50, 50, 0, DateTimeKind.Unspecified), "$2a$11$ZN4Q/qgtpUkjTvDawVoD6e3PSO0QVjdGEQt3nNKpCwmxez/hrCIxi" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "ID",
                keyValue: new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b"),
                columns: new[] { "DateCreate", "PasswordHash" },
                values: new object[] { new DateTime(2022, 6, 14, 9, 50, 50, 0, DateTimeKind.Unspecified), "$2a$11$UHdHCIOthFp0T6/6TUP22uUv3LZDbku6vK/9jGgYdhS033zECmi1W" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "ID",
                keyValue: new Guid("9c7b60b6-44b6-4a6f-9c4b-a0ece4672421"),
                columns: new[] { "DateCreate", "PasswordHash" },
                values: new object[] { new DateTime(2022, 6, 14, 9, 50, 51, 0, DateTimeKind.Unspecified), "$2a$11$gsJg8xBacEOlZzeBEwhvOuG76ZsYW1gHutdHDYp9nZQ7WfWr9r/HO" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "ID",
                keyValue: new Guid("a177d8ae-df9e-4259-909b-a7c790b9389a"),
                columns: new[] { "DateCreate", "PasswordHash" },
                values: new object[] { new DateTime(2022, 6, 14, 9, 50, 51, 0, DateTimeKind.Unspecified), "$2a$11$iy8RBb2no71OlZB0FXjc1uSxitSWapyVbgeKUCY4I61nTzSntlJve" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "ID",
                keyValue: new Guid("a277d8ae-df9e-4259-909b-a7c790b9389a"),
                columns: new[] { "DateCreate", "PasswordHash" },
                values: new object[] { new DateTime(2022, 6, 14, 9, 50, 51, 0, DateTimeKind.Unspecified), "$2a$11$JwD6gTtAjtopv1nkvy6LBO0qF3.WiidDqWB5caeTv3W0bkKMD6AU2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "ID",
                keyValue: new Guid("a377d8ae-df9e-4259-909b-a7c790b9389a"),
                columns: new[] { "DateCreate", "PasswordHash" },
                values: new object[] { new DateTime(2022, 6, 14, 9, 50, 52, 0, DateTimeKind.Unspecified), "$2a$11$2tsbAB76buChrpAWtQQCZePj8hybq08.afLy026q/k7erzQ/RAnv2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "ID",
                keyValue: new Guid("a477d8ae-df9e-4259-909b-a7c790b9389a"),
                columns: new[] { "DateCreate", "PasswordHash" },
                values: new object[] { new DateTime(2022, 6, 14, 9, 50, 52, 0, DateTimeKind.Unspecified), "$2a$11$8xdB5b8Tfurz1UIDrPtPlOB6cqcdwkcRUzxSJcxgjNqDDnD/G3qnC" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "ID",
                keyValue: new Guid("a68393ff-15fa-4136-85e2-71cdc505d8e8"),
                columns: new[] { "DateCreate", "PasswordHash" },
                values: new object[] { new DateTime(2022, 6, 14, 9, 50, 50, 0, DateTimeKind.Unspecified), "$2a$11$Gm8thijPpzN91gocsw4CWuAF7E8E7m2SDaz6f8Go.XI5UQ/TmI/OC" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "ID",
                keyValue: new Guid("e280d537-732c-465a-ab22-74d4cbb696c2"),
                columns: new[] { "DateCreate", "PasswordHash" },
                values: new object[] { new DateTime(2022, 6, 14, 9, 50, 51, 0, DateTimeKind.Unspecified), "$2a$11$Wzbq.tZjQB9kTzBedk71LedJHtufgcw7NBFHKyXT127cfjO9tkoLi" });

            migrationBuilder.UpdateData(
                table: "Exam",
                keyColumn: "ID",
                keyValue: new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                column: "DateExam",
                value: new DateTime(2022, 6, 14, 16, 50, 52, 341, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Exam",
                keyColumn: "ID",
                keyValue: new Guid("b22cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                column: "DateExam",
                value: new DateTime(2022, 6, 14, 16, 50, 52, 341, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "Exam",
                keyColumn: "ID",
                keyValue: new Guid("b32cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                column: "DateExam",
                value: new DateTime(2022, 6, 14, 16, 50, 52, 341, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.InsertData(
                table: "Exam.Question",
                columns: new[] { "ID", "ExamID", "QuestionID", "TeacherID" },
                values: new object[,]
                {
                    { new Guid("1d8351ab-82dd-436b-a699-cadcaa7dfbe0"), new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") },
                    { new Guid("9ab172d2-f2c0-485d-bc5d-2f666714e2e7"), new Guid("b22cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b4d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") },
                    { new Guid("9e9d3b27-9450-4b28-8ce2-b802fa45f734"), new Guid("b22cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96facc9b6d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") },
                    { new Guid("f1352baf-cbc3-4f8c-8bd8-ef291e3b391b"), new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b5d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") },
                    { new Guid("c34fd4f4-96e8-4fa4-9267-5d575931724d"), new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b4d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") },
                    { new Guid("dab62044-a562-411f-a29b-915457fb334b"), new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b3d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") },
                    { new Guid("28e12f28-3e99-40c7-abb0-400d20bc6d42"), new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b2d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") },
                    { new Guid("4eb78c04-6841-4ccd-88ca-a243150d59ed"), new Guid("b32cea50-b2e1-4467-91a0-7e96fccc9b1d"), new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b5d"), new Guid("2c273e26-c2dd-4956-8e13-7c25c2a1158b") }
                });

            migrationBuilder.UpdateData(
                table: "Student_Exam",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateExam",
                value: new DateTime(2022, 6, 14, 9, 50, 52, 343, DateTimeKind.Utc).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Student_Exam",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateExam",
                value: new DateTime(2022, 6, 14, 9, 50, 52, 343, DateTimeKind.Utc).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Student_Exam",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateExam",
                value: new DateTime(2022, 6, 14, 9, 50, 52, 343, DateTimeKind.Utc).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "Student_Exam",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateExam",
                value: new DateTime(2022, 6, 14, 9, 50, 52, 343, DateTimeKind.Utc).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "Student_Exam",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateExam",
                value: new DateTime(2022, 6, 14, 9, 50, 52, 343, DateTimeKind.Utc).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "Student_Exam",
                keyColumn: "ID",
                keyValue: 6,
                column: "DateExam",
                value: new DateTime(2022, 6, 14, 9, 50, 52, 343, DateTimeKind.Utc).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "Student_Exam",
                keyColumn: "ID",
                keyValue: 7,
                column: "DateExam",
                value: new DateTime(2022, 6, 14, 9, 50, 52, 343, DateTimeKind.Utc).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "Student_Exam",
                keyColumn: "ID",
                keyValue: 8,
                column: "DateExam",
                value: new DateTime(2022, 6, 14, 9, 50, 52, 343, DateTimeKind.Utc).AddTicks(2572));
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SamuraiAppCore.Data.Migrations
{
    public partial class addprocs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("" +
                "CREATE PROC GETSAMURAIS @NAME NVARCHAR(50) " +
                "AS SELECT * FROM SAMURIS WHERE NAME LIKE '%'+@NAME+'%'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

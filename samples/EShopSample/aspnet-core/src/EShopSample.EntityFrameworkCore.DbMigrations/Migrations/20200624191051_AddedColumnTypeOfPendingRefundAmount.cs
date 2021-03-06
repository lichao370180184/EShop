﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace EShopSample.Migrations
{
    public partial class AddedColumnTypeOfPendingRefundAmount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PendingRefundAmount",
                table: "EShopPaymentsPayments",
                type: "decimal(20,8)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PendingRefundAmount",
                table: "EShopPaymentsPaymentItems",
                type: "decimal(20,8)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PendingRefundAmount",
                table: "EShopPaymentsPayments",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,8)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PendingRefundAmount",
                table: "EShopPaymentsPaymentItems",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,8)");
        }
    }
}

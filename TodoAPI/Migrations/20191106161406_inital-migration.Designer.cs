﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoAPI.Models;

namespace TodoAPI.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20191106161406_inital-migration")]
    partial class initalmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("TodoAPI.Models.TodoItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("color");

                    b.Property<bool>("status");

                    b.Property<string>("task");

                    b.HasKey("id");

                    b.ToTable("toDoItems");
                });
#pragma warning restore 612, 618
        }
    }
}

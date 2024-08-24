using Demo01EFcore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Demo01EFcore.migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCORE1.Entites.Department", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("DepName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Departments");
            });

            modelBuilder.Entity("EFCORE1.Entites.Employee", b =>
            {
                b.Property<int>("EmpId")
                    .HasColumnType("int");

                b.Property<int?>("Age")
                    .IsRequired()
                    .HasColumnType("int");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("Varchar(50)");

                b.Property<string>("Phone")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<double>("Salary")
                    .HasColumnType(" Money");

                b.Property<string>("adress")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.HasKey("EmpId");

                b.ToTable("Employees");
            });
#pragma warning restore 612, 618
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01EFcore.EmployeeConfirgtion
{
    internal class EmployeeConfirgtion : IEntityTypeConfiguration<Employee>
    {

        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.EmpId);

            builder.Property(nameof(Employee.EmpId))
               .UseIdentityColumn(1, 1);

            builder.Property(e => e.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .HasDefaultValue("Ahmed");

            builder.Property(e => e.Salary)
                .HasColumnType("money");
        }
    }
}

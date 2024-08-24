using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01EFcore.Entites
{
    // EFcore Support 4 Ways For Mapping Classes IN Database(table , view , function)

    // 1. By Convention  --- (Default Dehaviour) 
    // 2. Data Annotation --- (Set Of Attriutes Used Data Validation)
    // 3. Fluent API      --- (Override OnCreateModel())
    // 4. Class Configurations


    // POCO CLASS
    // Plained Old CLR Object ClASS
    //internal class Employee
    //{

    //    public int Id { get; set; }         // public Numeric Property 'id' | 'Employeeid' : PK indentity(1,1)
    //    public string? Name { get; set; }    //Reference Type : Allow Null(.net 5) nvarchar(max)
    //    public double Salary { get; set; }  // Deciaml => value type : not allow null
    //    public int? Age { get; set; }       // nullable<int> : allow null [optional] 
    //    public string adress { get; set; } 
    //}

    //-----------------Data Annotation-------------------

    // [Table("Employee" , Schema ="Sales")]

    //internal class Employee
    //{
    //    [Key]
    //    // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    //    public int EmpId { get; set; }

    //    [Required]
    //    [Column(TypeName = "Varchar(50)")]
    //    [MaxLength(50)]
    //    [StringLength(50 , MinimumLength = 3 , ErrorMessage = " Invalid ")]
    //    public string? Name { get; set; }

    //    [Column(TypeName = " Money" )]
    //    public double Salary { get; set; }

    //    [Required]
    //    [Range(18, 60)]
    //    public int? Age { get; set; }

    //    [StringLength(50, MinimumLength = 3, ErrorMessage = " Invalid ")]
    //    public string adress { get; set; }

    //    [Phone]
    //    public string Phone { get; set; }

    //    [EmailAddress]
    //    public string Email { get; set; }

    //    [NotMapped]
    //    public double TotalSalary { get; set;}
    //}


    //-------------Fluent API------------------------
    internal class Employee
    {
        public int EmpId { get; set; }
        public string? Name { get; set; }
        public double Salary { get; set; }
        public int? Age { get; set; }
        public string adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double TotalSalary { get; set; }
    }

}

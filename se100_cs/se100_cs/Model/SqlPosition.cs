﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace se100_cs.Model
{
    [Table("tb_position")]
    public class SqlPosition
    {
        [Key]
        public long ID { get; set; }
        public string title { get; set; } = "";
        public string code { get; set; } = "";
        public long salary_coeffcient { get; set; }= 1;
        public SqlDepartment? department { get; set; }
        public List<SqlEmployee> employees { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}

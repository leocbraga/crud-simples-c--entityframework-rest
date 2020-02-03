using System.ComponentModel.DataAnnotations.Schema;

namespace testes_crud.Models {
    
    [Table("pessoa", Schema = "public")]
    public class Pessoa {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID {set; get;}
        
        [Column("nome")]
        public string Nome {get; set;}

    }
}
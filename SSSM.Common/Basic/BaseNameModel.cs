using System.ComponentModel.DataAnnotations;

namespace SSSM.Common.Basic
{
    public abstract class BaseNameModel : BaseModel
    {
        [Display(Name = "名称")]
        [Required]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

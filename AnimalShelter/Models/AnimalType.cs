using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class AnimalType
  {
    public AnimalType()
    {
      this.Animals = new HashSet<Animal>();
    }
    public int AnimalTypeId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Animal> Animals { get; set; }
  }
}
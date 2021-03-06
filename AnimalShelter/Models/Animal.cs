using System;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public DateTime AdmittanceDate { get; set; }
    public string Breed { get; set; }

    public int AnimalTypeId { get; set; }
    public virtual AnimalType AnimalType { get; set; }
  }
}
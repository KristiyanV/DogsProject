using DogApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogApp.Abstractions
{
   public interface IDogService
    {
        bool Create(string name, int age, string breed, string picture);
        bool UpdateDog(int dogId, string name, int age, string breed, string picture);
        List<Dog> GetDogs();
        List<Dog> GetDogs(string searchStringBreed, string searchStringName);
        Dog GetDogById(int dogId);
        bool RemoveById(int dogId);
    }
}

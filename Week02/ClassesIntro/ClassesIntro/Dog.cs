using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassesIntro
{
    public class Dog
    {
        public string Breed;
        public int HeightInInches;
        public string Name;
        public string Color;
        public bool IsBadDog;

        public void Bark()
        {
            MessageBox.Show("Bark");
        }

        public void SayName()
        {
            MessageBox.Show("My name is " + Name);
        }


        public Dog()
        {
            this.Breed = "German Shepard";
            this.HeightInInches = 2;
            this.Name = "Spiderman";
        }

        public Dog(string breed, int height, string name, string lastname)
        {
            this.Breed = breed;
            this.HeightInInches = height;
            this.Name = name;
            if (lastname == "Obama")
            {
                Name = "Bo";
            }
        }
    }
}
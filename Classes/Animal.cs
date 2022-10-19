namespace KESCHA.Classes
{
    class Animal
    {
        public string Name {get ; set ;}
        public int Age { get; set; }
        public int AgeDifference { get; set; }

        public Animal()
        {
            Name = "No name";
            Age = 0;
            AgeDifference = 0;
        }
        public Animal(int userAge, int animalAge, string animalName)
        {
            Name = animalName;
            Age = animalAge;
            // AgeDifference = CalculateAgeDifference(userAge, animalAge);
            CalculateAgeDifferenceWithNoReturn(userAge, animalAge);
        }
        private int CalculateAgeDifference(  int userAge,int animalAge)
        {
            return userAge - animalAge;
        }
        private void CalculateAgeDifferenceWithNoReturn( int userAge,int animalAge)
        {
            AgeDifference = userAge - animalAge;
        }

    }
}
class Fight  {

    static void Main (string[] args)
    
        {
            Character attaque = new Character()

            attaque.name = attaque;
            attaque.health = 100;
            attaque.strength = 50;
            attaque.defense = 70;

        const name = "john"





            Character attaquant = new Character()

            attaquant.name = attanquant ;
            attaquant.health = 110;
            attaquant.strength = 40;
            attaquant.defense = 80;

            attaquant.deathmatch(attaque)
        }


            public class Character {
    
                public string name;
                public int health;
                public int strength;
                public int defense;



                public void IsAlive() 
        {
            if (health <= 0){
                return false;
            } else {
                return true;
            }
        }

        public void Attack(Character target) {

            if( target.defense <= this.strength) {
                target.health = this.strength  - target.defense;
            }else {
                Console.WriteLine (target.name + " is to strong")
            }

            var alive = !target.Alive();

            if(alive){
                Console.WriteLine(target.name + "is dead")
            }
            }

        public void deathmatch (Character Fighter){
            Console.WriteLine("Ready ? GO!")

            while (this.IsAlive() && Fighter.IsAlive()){

                this.attack(Fighter)

                if (Fighter.IsAlive()){
                    Fighter.attack(this)
                }
            }

            Console.WriteLine("A Fighter is dead")
        }

            

    
}

Character attaque = new Character()

attaque.name = attaque;
attaque.health = 100;
attaque.strength = 50;
attaque.defense = 70;

Character attaquant = new Character()

attaquant.name = attanquant ;
attaquant.health = 110;
attaquant.strength = 40;
attaquant.defense = 80;


}
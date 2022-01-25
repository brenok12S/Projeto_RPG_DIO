namespace Projeto_DIO.src.Entities
{
    public class Wizards : Hero
    {

        public Wizards(string Name, int Level, string HeroType) {

            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;

        }

        public override string Attack() {
            return this.Name + " Lançou magia";
        }
        
        public string Attack(int Bonus) {

             if(Bonus > 6) {
                return this.Name + " Lançou Magia super efetiva com bonus de " + Bonus;
            } else {
                return this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus;
            }

        }

         
    }
}
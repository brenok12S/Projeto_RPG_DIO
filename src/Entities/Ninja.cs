namespace Projeto_DIO.src.Entities
{
    public class Ninja : Hero {
        public Ninja(string Name, int Level, string HeroType) {

            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;

        }

        public override string Attack() {
            return this.Name + " Acertou um corte perfurante ";
        }

        public string Attack(int Bonus) {

             if(Bonus > 6) {
                return this.Name + " Acertou um combo de ataques com dano de  " + Bonus + " " + (Bonus - 1)+ " " + (Bonus - 2);
            } else {
                return this.Name + " Lançou uma shuriken com dano de  " + Bonus;
            }

        }

    }
}
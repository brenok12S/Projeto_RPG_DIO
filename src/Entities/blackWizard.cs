namespace Projeto_DIO.src.Entities 
{
    public class blackWizard : Hero 
    {
        public blackWizard(string Name, int Level, string HeroType) {

            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;

        }

        public override string Attack() {
            return this.Name + " Lançou magia envolta por escuridão";
        }

        public string Attack(int Bonus) {

             if(Bonus > 6) {
                return this.Name + " Lançou Magia envolta por escuridão super efetiva com bonus de " + Bonus;
            } else {
                return this.Name + " Lançou uma magia envolta com escuridão com força fraca com bonus de " + Bonus;
            }

        }

    }
}
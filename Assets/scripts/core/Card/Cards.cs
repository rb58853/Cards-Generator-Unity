namespace Cards
{
    public abstract class Card
    {
        public string? name { get; protected set; }
        public string? description { get; protected set; }


        protected void ProtectedPrint()
        {
            //Console.WriteLine("Protected void");
        }

        /// <summary>
        /// Para poder usar este metodo es necesario hacer un AST de c# para acceder al codigo fuente. Esto es contenido de compiladores/transpiladores. La opcion rapida y simple es usar protected en lugar de private. Esto trae el problema de modificar codigo fuente. 
        /// </summary>
        private void PrivatePrint()
        {
            //Console.WriteLine("Private void");
        }
    }
    public abstract class Monster : Card
    {
        /// <summary>
        /// Sumary de atk
        /// </summary>
        public virtual int atk { get; protected set; }
        public int atkArea { get; protected set; }
        public int defense { get; protected set; }
        public int healt { get; private set; } //Test private property
        private int atkToIncrese;


        //Test properties fields type
        static int staticInt;
        public string nullSet;
        private string privateString;
        protected string? protectedString;
        static string varStaticProp { get; set; }

        //////////////////////////////////

        public virtual void TargetAttack(Monster monster)
        {
            //Attack a monster
            // //Console.WriteLine($"Attack to monster {monster.name} with damage = {atk}");
            monster.RecibedDamage(this.atk);
        }

        public virtual void AreaAttack(Monster[] monsters)
        {
            //Attack a list of monsters
            foreach (Monster monster in monsters)
            {
                // //Console.WriteLine($"Attack to monster {monster.name} with damage = {atkArea}");
                monster.RecibedDamage(this.atkArea);
            }
        }

        public virtual void IncreseAttack(int value)
        {
            // //Console.WriteLine($"Monster {name} damage attack incresed in {value}");
            this.atk += value;
        }

        public virtual void IncreseAttack()
        {
            //Console.WriteLine($"Monster {name} damage attack incresed in {atkToIncrese}");
            this.atk += this.atkToIncrese;
        }

        public virtual void RecibedDamage(int damage)
        {
            this.healt -= damage;
            //Console.WriteLine($"Monster {this.name} recibed damage = {damage}, currently healt = {this.healt}");
        }
    }

}
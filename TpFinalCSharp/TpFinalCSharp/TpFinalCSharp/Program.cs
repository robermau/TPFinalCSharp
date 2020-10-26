
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace TpFinalCSharp
{
    class Program
    {
        static void Main(string[] args)
        { }

        public class Personaje   // CLASE PADRE
        {

            protected Personaje() { salud = 100; }
            public Personaje(uint s, uint m, uint f)
            {
                salud = s;
                mana = m;
                flechas = f;
            }

            public Personaje(uint s)
            {
            }

            ~Personaje() { }

            public void Atacar() { }
            public void TakeDmg(uint s)
            {

                salud -= s;
            }

            public uint salud;
            private uint flechas;




            // HERENCIAS //


            // Clas: Mage //
            public class Mage : Personaje
            {
                public uint mana;

                private Hechizo[] grimorio = new Hechizo[2];
                public Mage() : base() { mana = 80; }
                public Mage(uint s, uint m) : base(s) { mana = m; }


                public Mage()
                {
                    grimorio[0] = new Hechizo(20);
                    grimorio[1] = new Hechizo(35);
                }
                ~Mage()
                {

                }
            }


            public void CastearHechizo() { }



            class Hechizo
            {
                protected uint costo;
                public Hechizo(uint s) { costo = s; }
                ~Hechizo() { }

                public void Castear()
                {
                    Console.WriteLine("Casting Skill");
                }

                public uint Getcosto()
                {
                    return costo;
                }

                public class Fireball : Hechizo
                {
                    public Fireball(uint c) { costo = c; }
                    ~Fireball() { }

                    public void Burning() { }

                    protected uint costo;
                    public uint Costo
                    {
                        get { return costo; }
                    }
                }
            }


        }

        public void Castear()
        {


        }


        //Clas: Ranger //

        public class Ranger : Personaje
        {
            public Ranger() : base() { salud = 100; flechas = 8; mana = 5; }
            public Ranger(uint f, uint s, uint m) : base()
            {
                salud = s; flechas = (int)f; mana = (int)m;
            }
            ~Ranger() { }

            public void ArrowArray() { }

            private int flechas;
            private int mana;


        }

        public class ArrowArray : Ranger
        {
            public ArrowArray(uint c) { costo = c; }
            ~ArrowArray() { }

            public void LanzarFlechas() { }

            protected uint costo;
            public uint Costo
            {
                get { return costo; }
            }
        }


        //Clas: Warrior

        public class Warrior : Personaje
        {

            public Warrior() : base() { salud = 120; }
            public Warrior(uint s) : base()
            {
                salud = s;

            }
            ~Warrior()
            {

            }

            public void PsicalAtk() { }
            private uint salud;

        }
        public class PsicalAtk : Warrior
        {
            public PsicalAtk(uint c) { costo = c; }
            ~PsicalAtk() { }

            public void GolepEspada() { }

            protected uint costo;
            public uint Costo
            {
                get { return costo; }
            }
        }

        // Clas: Priest

        public class Priest : Personaje
        {

            public Priest() : base() { mana = 100; }
            public Priest(uint m) : base()
            {

                mana = m;
            }
            ~Priest()
            {

            }

            public void Healer() { }
            private uint mana;

        }



        public class Healer : Priest
        {
            public Healer(uint c) { costo = c; }
            ~Healer() { }

            public void Healing() { }

            protected uint costo;
            public uint Costo
            {
                get { return costo; }
            }
        }

    }
}





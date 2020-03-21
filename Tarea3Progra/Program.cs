using System;

namespace Tarea3Progra
{
    class Program
    {
        static void Main(string[] args)
        {
            Horario mat1 = new Horario();
            Horario mat2 = new Horario();
            Horario mat3 = new Horario();
            Horario mat4 = new Horario();
            Horario mat5 = new Horario();
            Horario mat6 = new Horario();

            public void MostrarDatos()
            {
                mat1.materia = "Programación Orientada a Objetos";
                mat2.materia = "Entorno Económico";
                mat3.materia = "Persona y Sociedad";
                mat4.materia = "Cálculo Diferencial";
                mat5.materia = "Álgebra Lineal";
                mat6.materia = "Redacción y Expresión Oral";

                mat1.dia = "Martes, Jueves";
                mat2.dia = "Lunes, Miércoles";
                mat3.dia = "Martes, Jueves";
                mat4.dia = "Martes, Jueves";
                mat5.dia = "Miércoles, Viernes";
                mat6.dia = "Martes, Viernes";

                mat1.dura = "120 min";
                mat2.dura = "90 min";
                mat3.dura = "90 min";
                mat4.dura = "120 min";
                mat5.dura = "120 min";
                mat6.dura = "90 min";

                mat1.hini = "11:30 am";
                mat2.hini = "9:00 am(Lun), 2:30 pm(Mie)";
                mat3.hini = "10:00 am";
                mat4.hini = "7:00 am";
                mat5.hini = "9:00 am";
                mat6.hini = "2:30 pm";

                mat1.hfin = "1:30 pm";
                mat2.hfin = "10:30(Lun), 4:00(Mie)";
                mat3.hfin = "11:30 am";
                mat4.hfin = "9:00 am";
                mat5.hfin = "11:00 am";
                mat6.hfin = "4:00 pm";

                Console.WriteLine("Materia:\n" + mat1.materia + "\n" + mat2.materia + "\n" + mat3.materia + "\n" + mat4.materia + "\n" + mat5.materia + "\n" + mat6.materia);
                Console.WriteLine("Día:\n" + mat1.dia + "\n" + mat2.dia + "\n" + mat3.dia + "\n" + mat4.dia + "\n" + mat5.dia + "\n" + mat6.dia);
                Console.WriteLine("Duración:\n" + mat1.dura + "\n" + mat2.dura + "\n" + mat3.dura + "\n" + mat4.dura + "\n" + mat5.dura + "\n" + mat6.dura);
                Console.WriteLine("Inicia:\n" + mat1.hini + "\n" + mat2.hini + "\n" + mat3.hini + "\n" + mat4.hini + "\n" + mat5.hini + "\n" + mat6.hini);
                Console.WriteLine("Termina:\n" + mat1.hfin + "\n" + mat2.hfin + "\n" + mat3.hfin + "\n" + mat4.hfin + "\n" + mat5.hfin + "\n" + mat6.hfin);

            }
        }

    }
    class Horario
    {

        public string materia;
        public string dia;
        public string dura;
        public string hfin;
        public string hini;
        public Horario(string materia, string dia, string dura, string hfin, string hini)
        {
            this.materia = materia;
            this.dia = dia;
            this.dura = dura;
            this.hfin = hfin;
            this.hini = hini;
        }
        
    }

}

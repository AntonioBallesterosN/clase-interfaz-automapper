using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_interfaz_automapper
{
    //interface IMaterialDeMueble
    //{
    //    string material();
    //}
    class Program
    {
        static void Main(string[] args)
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<MueblesBaseDeDatos, Muebles>();
                cfg.CreateMap<Muebles, MueblesBaseDeDatos>();
                cfg.CreateMap<AutomovilBaseDeDatos, Automovil>();
                cfg.CreateMap<Automovil, AutomovilBaseDeDatos>();
                cfg.CreateMap<PersonaBaseDeDatos, Persona>();
                cfg.CreateMap<Persona, PersonaBaseDeDatos>();
            });

            mapperConfig.AssertConfigurationIsValid();

            var mapper = mapperConfig.CreateMapper();
            // aqui se extran datos de base de datos a usuario
            var mueblesBaseDeDatos = new MueblesBaseDeDatos
            {
                Id = 3,
                Tipo = "Consola",
                Material = "Pino"
            };
            var automovilBaseDeDatos = new AutomovilBaseDeDatos
            {
                Id = 9,
                Transmicion = "Manual",
                Marca = "VW"
            };
            var personaBaseDeDatos = new PersonaBaseDeDatos
            {
                Id = 5,
                Nombre = "Antonio",
                Apellido = "Ballesteros"
            };

            var muebles = mapper.Map<Muebles>(mueblesBaseDeDatos);
            var automovil = mapper.Map<Automovil>(automovilBaseDeDatos);
            var persona = mapper.Map<Persona>(personaBaseDeDatos);
            //
            // aqui se extraen datos de usuario a base de datos
            var muebles2 = new Muebles
            {
                Id = 6,
                Tipo = "Sillon",
                Material = "Caoba"
            };
            var automovil2 = new Automovil
            {
                Id = 6,
                Transmicion = "Automatico",
                Marca = "Renault"
            };
            var persona2 = new Persona
            {
                Id = 7,
                Nombre = "Juanito",
                Apellido = "Banana"
            };

            var mueblesBaseDeDatos2 = mapper.Map<MueblesBaseDeDatos>(muebles2);
            var automovilBaseDeDatos2 = mapper.Map<AutomovilBaseDeDatos>(automovil2);
            var personaBaseDeDatos2 = mapper.Map<PersonaBaseDeDatos>(persona2);
            //

            Console.WriteLine(mueblesBaseDeDatos2.Tipo);
            Console.WriteLine(muebles2.Tipo);
            Console.WriteLine(automovilBaseDeDatos2.Marca);
            Console.WriteLine(automovil2.Marca);
            Console.WriteLine(personaBaseDeDatos2.Nombre);
            Console.WriteLine(persona2.Nombre);

            Console.WriteLine(mueblesBaseDeDatos.Tipo);
            Console.WriteLine(muebles.Tipo);
            Console.WriteLine(automovilBaseDeDatos.Marca);
            Console.WriteLine(automovil.Marca);
            Console.WriteLine(personaBaseDeDatos.Nombre);
            Console.WriteLine(persona.Nombre);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO_Simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cria medico
            Medico medico = null;
            try
            {
                medico = new Medico("João Silva", new DateTime(2000, 5, 12), 123456789, new Morada(), 1234, ESPECIALIDADE.Cardiologia);
                Console.WriteLine("Criado");
            }
            catch (MedicoException ex)
            {
                Console.WriteLine($"Erro ao criar médico: {ex.Message}");
            }
            try
            {
                medico.EditaMedico("Alfredo Lopes", medico.DataN, medico.NIF, medico.Morada, medico.CRM, medico.Especialidade);
                Console.WriteLine("Editado");
            }
            catch (MedicoException ex)
            {
                Console.WriteLine($"Erro ao criar médico: {ex.Message}");
            }

            /*
            try
            {
                // Criar instância de Medicos e adicionar médicos
                Medicos listaMedicos = new Medicos();
                listaMedicos.AdicionarMedico(new Medico("João Silva", new DateTime(1980, 5, 12), 123456789, new Morada(), 1234, ESPECIALIDADE.Cardiologia));
                listaMedicos.AdicionarMedico(new Medico("Maria Santos", new DateTime(1985, 8, 20), 987654321, new Morada(), 5678, ESPECIALIDADE.Neurologia));
                listaMedicos.AdicionarMedico(new Medico("Carlos Costa", new DateTime(1990, 12, 15), 123987456, new Morada(), 9012, ESPECIALIDADE.Cardiologia));

                RegrasMedicos regrasMedicos = new RegrasMedicos();

                // Pesquisa com permissões Low
                Console.WriteLine("== Permissões Low ==");
                var resultadoLow = regrasMedicos.PesquisaMedicos(listaMedicos, ESPECIALIDADE.Cardiologia, PERMISSOES.Low);
                resultadoLow.ForEach(m => Console.WriteLine(m.ToString()));

                // Pesquisa com permissões High
                Console.WriteLine("\n== Permissões High ==");
                var resultadoHigh = regrasMedicos.PesquisaMedicos(listaMedicos, ESPECIALIDADE.Cardiologia, PERMISSOES.High);
                resultadoHigh.ForEach(m => Console.WriteLine(m.ToString()));

                // Pesquisa com permissões None (causa exceção)
                Console.WriteLine("\n== Permissões None ==");
                var resultadoNone = regrasMedicos.PesquisaMedicos(listaMedicos, ESPECIALIDADE.Cardiologia, PERMISSOES.None);
            }
            catch (RegrasMedicosException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            */                

            Console.ReadKey();
        }
    }
}

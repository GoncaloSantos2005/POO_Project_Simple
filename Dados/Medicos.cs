/*
*	<copyright file="TrabalhoPOO_Simples.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>12/2/2024 11:13:59 AM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;

namespace TrabalhoPOO_Simples
{
    /// <summary>
    /// Purpose:
    /// Created by: gonca
    /// Created on: 12/2/2024 11:13:59 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Medicos
    {
        #region Attributes
        List<Medico> medicos;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Medicos()
        {
            medicos = new List<Medico>();
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Retorna todos os médicos da lista.
        /// </summary>
        /// <returns>Lista de objetos <see cref="Medico"/>.</returns>
        public List<Medico> ObterTodos()
        {
            return medicos;
        }

        public int AdicionarMedico(Medico medico)
        {
            int resultado = ValidarListaMedicos.ValidarMedico(medico);
            if (resultado != 1)
                throw new ListaMedicosException("Médico não adicionado", resultado);
            medicos.Add(medico);
            return resultado;
        }

        public int RemoverMedico(int crm)
        {
            try
            {
                Medico medico = FindMedico(crm);
                medicos.Remove(FindMedico(crm));
            }
            catch (ListaMedicosException ex) 
            {
                throw ex;
            }
            return 1;
        }

        private Medico FindMedico(int crm)
        {
            try { 
                if (crm < 0)
                    throw new ListaMedicosException("O CRM deve ser um número positivo.", -2);
                Medico medico = medicos.Find(m => m.CRM == crm);
                ValidarListaMedicos.ValidarMedico(medico);
                return medico;
            }
            catch (ListaMedicosException ex)
            {
                throw ex;    
            }
        }

        public List<Medico> ObterMedicoFiltro(ESPECIALIDADE esp)
        {
            List<Medico> lista = medicos.FindAll(a => a.Especialidade.Equals(esp));
            if (lista.Count == 0)
                return null;

            return lista;
        }
        public List<MiniMedico> ObterMiniMedicoFiltro(ESPECIALIDADE esp)
        {
            List<Medico> listaFiltro = medicos.FindAll(a => a.Especialidade.Equals(esp));
            if (listaFiltro.Count == 0)
                return null;

            List<MiniMedico> lista = new List<MiniMedico>();

            foreach(Medico medico in listaFiltro)
            {                
                lista.Add(new MiniMedico(medico.Nome, medico.Especialidade));
            }
            return lista;
        }

        public int OrganizarMedicosAlfabeticamente()
        {   

            int resultado = ValidarListaMedicos.ValidarLista(this);
            
            if (resultado != 1)
                throw new ListaMedicosException("Lista não foi organizada com sucesso", resultado);

            this.medicos.Sort(); //usa o metodo implementado em Medico para organizar alfabeticamente
            
            return 1;
        }

        /// <summary>
        /// Retorna o número total de médicos na lista.
        /// </summary>
        public int Count
        {
            get { return medicos.Count; }
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Medicos()
        {
        }
        #endregion

        #endregion
    }
}

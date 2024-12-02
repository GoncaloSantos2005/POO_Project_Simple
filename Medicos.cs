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
        public void AdicionarMedico(Medico medico)
        {
            if(!(medico is Medico))
                throw new ListaMedicosException("O objeto não é do tipo Medico");

            if (medico == null)
                throw new ListaMedicosException("A referência ao objeto medico não pode ser nula");
            medicos.Add(medico);
        }

        public void RemoverMedico(int crm)
        {
            if (crm < 0)
                throw new ListaMedicosException("O CRM deve ser um número positivo.");

            medicos.Remove(FindMedico(crm));
        }

        private Medico FindMedico(int crm)
        {
            if (crm < 0)
                throw new ListaMedicosException("O CRM deve ser um número positivo.");
            Medico medico = medicos.Find(m => m.CRM == crm);
            if (medico == null)
                throw new ListaMedicosException("Médico não encontrado, valide o crm e tente novamente");
            return medico;
        }

        public List<Medico> ObterMedicoFiltro(ESPECIALIDADE esp)
        {
            List<Medico> lista = medicos.FindAll(a => a.Especialidade.Equals(esp));
            if (lista.Count == 0)
                throw new RegrasMedicosException("Não foi encontrado nenhum medico na lista");

            return lista;
        }
        public List<MiniMedico> ObterMiniMedicoFiltro(ESPECIALIDADE esp)
        {
            List<Medico> listaFiltro = medicos.FindAll(a => a.Especialidade.Equals(esp));
            if (listaFiltro.Count == 0)
                throw new RegrasMedicosException("Não foi encontrado nenhum medico na lista");

            List<MiniMedico> lista = new List<MiniMedico>();

            foreach(Medico medico in listaFiltro)
            {                
                lista.Add(new MiniMedico(medico.Nome, medico.Especialidade));
            }
            return lista;
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

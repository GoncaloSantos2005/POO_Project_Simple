/*
*	<copyright file="TrabalhoPOO_Simples.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>12/1/2024 6:21:02 PM</date>
*	<description></description>
**/
using System;

namespace TrabalhoPOO_Simples
{
    public enum ESPECIALIDADE
    {
        Ginecologia = 0,
        Neurologia = 1,
        Cardiologia = 2,
    }
    /// <summary>
    /// Purpose:
    /// Created by: gonca
    /// Created on: 12/1/2024 6:21:02 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Medico : Pessoa
    {
        #region Attributes
        int crm;
        ESPECIALIDADE especialidade;       

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Medico()
        {
        }
        
        public Medico(string nome, DateTime dataN, int nif, Morada morada, int crm, ESPECIALIDADE especialidade)
        {
            if (string.IsNullOrEmpty(nome))
                throw new MedicoException("O nome do médico não pode ser vazio.");

            if (dataN > DateTime.Now.AddYears(-18))
                throw new MedicoException("O médico tem de ter mais de 18 anos.");

            if (nif <= 0 || nif.ToString().Length != 9)
                throw new MedicoException("O NIF do médico é inválido.");

            if (morada == null)
                throw new MedicoException("A morada do médico não pode ser nula.");

            if (crm <= 0)
                throw new MedicoException("O CRM deve ser um número positivo.");

            if (!Enum.IsDefined(typeof(ESPECIALIDADE), especialidade))
            {
                throw new MedicoException("A especialidade do médico é inválida.");
            }

            base.Nome = nome;
            base.DataN = dataN;
            base.NIF = nif;
            base.Morada = morada;
            this.crm = crm;
            this.especialidade = especialidade;
        }

        #endregion

        #region Properties
        public int CRM
        {
            get { return crm; }
            set { crm = value; }
        }

        public ESPECIALIDADE Especialidade
        {
            get { return especialidade; }
            set { especialidade = value; }
        }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        public void EditaMedico(string novoNome, DateTime novaDataN, int novoNif, Morada novaMorada, int novoCrm, ESPECIALIDADE novaEspecialidade)
        {
            if (this == null)
            {
                throw new MedicoException("O objeto médico não pode ser nulo.");
            }

            if (string.IsNullOrWhiteSpace(novoNome))
            {
                throw new MedicoException("O nome do médico não pode ser vazio ou nulo.");
            }

            if (novaDataN > DateTime.Now.AddYears(-18))
            {
                throw new MedicoException("O médico deve ser maior de 18 anos.");
            }

            if (novoNif.ToString().Length != 9)
            {
                throw new MedicoException("O NIF deve conter 9 dígitos.");
            }

            if (novaMorada == null)
            {
                throw new MedicoException("A nova morada não pode ser nula.");
            }

            if (novoCrm <= 0)
            {
                throw new MedicoException("O CRM deve ser um número positivo.");
            }

            if (!Enum.IsDefined(typeof(ESPECIALIDADE), novaEspecialidade))
            {
                throw new MedicoException("Especialidade inválida.");
            }

            this.Nome = novoNome;
            this.DataN = novaDataN;
            this.NIF = novoNif;
            this.Morada = novaMorada;
            this.CRM = novoCrm;
            this.Especialidade = novaEspecialidade;
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Medico()
        {
        }
        #endregion

        #endregion
    }
}

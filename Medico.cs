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
        public Medico CriaMedico(string nome, DateTime dataN, int nif, Morada morada, int crm, ESPECIALIDADE especialidade)
        {
            return new Medico(nome, dataN, nif, morada, crm, especialidade);
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

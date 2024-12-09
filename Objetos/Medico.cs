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
    public class Medico : Pessoa, IComparable<Medico>
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

        #region IComparable<Medico> Implementation
        /// <summary>
        /// Compara os nomes dos médicos para ordenar alfabeticamente.
        /// </summary>
        /// <param name="outroMedico">Outro objeto Medico para comparação.</param>
        /// <returns>Valor negativo se este nome for menor, 0 se igual, positivo se maior.</returns>
        public int CompareTo(Medico outroMedico)
        {
            int res = ValidarMedico.ValidarObjetoMedico(outroMedico);
            if (res != 1)
                throw new MedicoException("Operação de Comparar foi interrompida! ", res);
            return string.Compare(this.Nome, outroMedico.Nome, StringComparison.OrdinalIgnoreCase);
        }
        #endregion
        
        #region OtherMethods
        public Medico EditaMedico(string novoNome, DateTime novaDataN, int novoNif, Morada novaMorada, ESPECIALIDADE novaEspecialidade)
        {
            int resultado = ValidarMedico.ValidarCamposMedico(novoNome, novaDataN, novoNif, novaMorada, novaEspecialidade);
            if (resultado != 1)
            {
                return null;
            }

            this.Nome = novoNome;
            this.DataN = novaDataN;
            this.NIF = novoNif;
            this.Morada = novaMorada;
            this.Especialidade = novaEspecialidade;

            return this;
        }

        /// <summary>
        /// Cria um objeto da classe <see cref="Medico"/> após validar os parâmetros fornecidos.
        /// </summary>
        /// <param name="nome">Nome do médico.</param>
        /// <param name="dataN">Data de nascimento do médico.</param>
        /// <param name="nif">Número de Identificação Fiscal (NIF).</param>
        /// <param name="morada">Objeto do tipo <see cref="Morada"/> contendo a morada do médico.</param>
        /// <param name="crm">CRM do médico.</param>
        /// <param name="especialidade">Especialidade do médico.</param>
        /// <returns>Um objeto do tipo <see cref="Medico"/>.</returns>
        /// <exception cref="MedicoException">
        /// Lançada quando os parâmetros fornecidos não são válidos.
        /// </exception>
        public static Medico CriaMedico(string nome, DateTime dataN, int nif, Morada morada, int crm, ESPECIALIDADE especialidade)
        {
            int resultado = ValidarMedico.ValidarCamposMedico(nome, dataN, nif, morada, especialidade);
            if (resultado != 1)
            {
                throw new MedicoException("Parâmetros inválidos", resultado);
            }
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

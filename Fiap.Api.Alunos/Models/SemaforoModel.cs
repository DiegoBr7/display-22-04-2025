﻿namespace Fiap.Api.Alunos.Models
{
    public class SemaforoModel
    {
        public long SemaforoId { get; set; }
        public required string Localizacao { get; set; }
        public required string Status { get; set; }
        public int? fluxoTrafego { get; set; }
        public DateTime DataHora { get; set; }

    }
}

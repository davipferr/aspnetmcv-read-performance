using QueryPerformance.Models;
using QueryPerformance.Models.ViewModels;

namespace QueryPerformance.Helpers.Mappers
{
    public static class OneThousandRowsMapper
    {
        public static OneThousandRowsViewModel ToViewModel(OneThousandRows entity)
        {
            if (entity == null)
                return null;

            return new OneThousandRowsViewModel
            {
                Id            = entity.Id,
                Nome          = entity.Nome,
                Idade         = entity.Idade,
                Cpf           = entity.Cpf,
                Rg            = entity.Rg,
                DataNasc      = entity.DataNasc,
                Sexo          = entity.Sexo,
                Signo         = entity.Signo,
                Mae           = entity.Mae,
                Pai           = entity.Pai,
                Email         = entity.Email,
                Cep           = entity.Cep,
                Endereco      = entity.Endereco,
                Numero        = entity.Numero,
                Bairro        = entity.Bairro,
                Cidade        = entity.Cidade,
                Estado        = entity.Estado,
                TelefoneFixo  = entity.TelefoneFixo,
                Celular       = entity.Celular,
                Altura        = entity.Altura,
                Peso          = entity.Peso,
                TipoSanguineo = entity.TipoSanguineo,
                Cor           = entity.Cor,
            };
        }

        public static OneThousandRows ToEntity(OneThousandRowsViewModel viewModel)
        {
            if (viewModel == null)
                return null;

            return new OneThousandRows
            {
                Id            = entity.Id,
                Nome          = entity.Nome,
                Idade         = entity.Idade,
                Cpf           = entity.Cpf,
                Rg            = entity.Rg,
                DataNasc      = entity.DataNasc,
                Sexo          = entity.Sexo,
                Signo         = entity.Signo,
                Mae           = entity.Mae,
                Pai           = entity.Pai,
                Email         = entity.Email,
                Cep           = entity.Cep,
                Endereco      = entity.Endereco,
                Numero        = entity.Numero,
                Bairro        = entity.Bairro,
                Cidade        = entity.Cidade,
                Estado        = entity.Estado,
                TelefoneFixo  = entity.TelefoneFixo,
                Celular       = entity.Celular,
                Altura        = entity.Altura,
                Peso          = entity.Peso,
                TipoSanguineo = entity.TipoSanguineo,
                Cor           = entity.Cor,
            };
        }
    }
} 
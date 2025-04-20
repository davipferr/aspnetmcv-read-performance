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
                Id            = viewModel.Id,
                Nome          = viewModel.Nome,
                Idade         = viewModel.Idade,
                Cpf           = viewModel.Cpf,
                Rg            = viewModel.Rg,
                DataNasc      = viewModel.DataNasc,
                Sexo          = viewModel.Sexo,
                Signo         = viewModel.Signo,
                Mae           = viewModel.Mae,
                Pai           = viewModel.Pai,
                Email         = viewModel.Email,
                Cep           = viewModel.Cep,
                Endereco      = viewModel.Endereco,
                Numero        = viewModel.Numero,
                Bairro        = viewModel.Bairro,
                Cidade        = viewModel.Cidade,
                Estado        = viewModel.Estado,
                TelefoneFixo  = viewModel.TelefoneFixo,
                Celular       = viewModel.Celular,
                Altura        = viewModel.Altura,
                Peso          = viewModel.Peso,
                TipoSanguineo = viewModel.TipoSanguineo,
                Cor           = viewModel.Cor,
            };
        }
    }
} 
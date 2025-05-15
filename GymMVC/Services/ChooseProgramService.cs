using GymMVC.Contexts;
using GymMVC.Models;

namespace GymMVC.Services
{
    public class ChooseProgramService
    {
        private readonly AppDbContext _context;

        public ChooseProgramService()
        {
            _context = new AppDbContext();
        }
        #region Create
        public void CreateChooseProgram(ChooseProgram program)
        {
            _context.ChoosePograms.Add(program);
            _context.SaveChanges();
        }
        #endregion

        #region Read
        public ChooseProgram GetChooseProgramById(int id)
        {
            ChooseProgram? chooseProgram = _context.ChoosePograms.Find(id);
            if (chooseProgram is null)
            {
                throw new Exception($"databasa daxilinde {id} id-e sahib data tapilmadi ");
            }
            return chooseProgram;
        }
        #endregion

        public List<ChooseProgram> GetAllChoseProgram()
        {
            List<ChooseProgram> choosePrograms = _context.ChoosePograms.ToList();
            return choosePrograms;
        }

        #region Update
        public void UpdatedChooseProgram(int id, ChooseProgram program)
        {
            if (program is null)
            {
                throw new Exception("id-ler ust uste dusur ");

            };

        }
        #endregion

        #region Delete

        #endregion

    }
}

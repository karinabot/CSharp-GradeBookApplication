using GradeBook.Enums;


namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isweighted)
            : base(name, isweighted)
        {
            this.Type = GradeBookType.Standard;

        }
    }
}

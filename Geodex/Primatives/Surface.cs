
namespace Geodex
{
    public abstract class Field
    {

        #region members

        protected UV uv = new UV();
        protected Point p = new Point();

        #endregion

        #region constructors

        public Field()
        {

        }

        #endregion

        #region properties

        public virtual UV Parameter
        {
            get { return uv; }
            set
            {
                this.uv = value;
                Evaluate();
            }
        }

        public virtual double U
        {
            get { return uv.U; }
            set
            {
                this.uv.U = value;
                Evaluate();
            }
        }

        public virtual double V
        {
            get { return uv.V; }
            set
            {
                this.uv.V = value;
                Evaluate();
            }
        }

        #endregion

        #region methods

        protected virtual void Evaluate()
        {
        }

        protected virtual void EvaluateCartesian()
        {
        }

        public virtual Point Location
        {
            get { return p; }
        }
        #endregion

    }
}

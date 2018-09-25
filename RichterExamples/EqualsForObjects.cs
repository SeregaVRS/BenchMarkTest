namespace RichterExamples
{
    public class EqualsForObjects
    {
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            //if (obj == null) return false;
            //if (this.GetType() != obj.GetType()) return false;
            //if (!object.ReferenceEquals(this, obj)) return false;

            return obj != null && this.GetType() == obj.GetType() && object.ReferenceEquals(this, obj);
        }

        public bool CustomEquals(object obj1, object obj2)
        {
            return 
                obj1 != null && 
                obj2 != null && 
                obj1.GetType() == obj2.GetType() && 
                object.ReferenceEquals(obj1, obj2);
        }
    }
}

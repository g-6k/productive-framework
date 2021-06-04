using System.Collections.Generic;
using System.Linq;

namespace ProductiveDDD
{
    //TODO: Add snippet and rules references
    /// <summary>
    ///   Implement this class to create left ValueObject. Value objects must be immutable.
    /// </summary>
    /// <remarks>
    ///   You can use the snippet xxxx to derive from this class. Rules xxxx, xxxx are associated to value objects
    /// </remarks>
    /// <seealso href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/implement-value-objects"/>
    public abstract class ValueObject
    {
        /// <summary>
        ///   Implements the operator !=.
        /// </summary>
        /// <remarks>
        ///   Use equality of values returned by the abstract method <c>GetEqualityComponents()</c>
        /// </remarks>
        /// <returns>
        ///   The result of the operator.
        /// </returns>
        public static bool operator !=(ValueObject left, ValueObject right)
        {
            return !(left == right);
        }

        /// <summary>
        ///   Implements the operator ==.
        /// </summary>
        /// <remarks>
        ///   Use equality of values returned by the abstract method <c>GetEqualityComponents()</c>
        /// </remarks>
        /// <returns>
        ///   The result of the operator.
        /// </returns>
        public static bool operator ==(ValueObject left, ValueObject right)
        {
            if (left is null && right is null)
                return true;

            if (left is null || right is null)
                return false;

            return left.Equals(right);
        }

        /// <summary>
        ///   Determines whether the specified <see cref="ValueObject"/>, is equal to this instance.
        /// </summary>
        /// <param name="obj">
        ///   The <see cref="ValueObject"/> to compare with this instance.
        /// </param>
        /// <remarks>
        ///   Use equality of values returned by the abstract method <c>GetEqualityComponents()</c>
        /// </remarks>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="ValueObject"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }

            var other = (ValueObject)obj;

            return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
        }

        /// <summary>
        ///   Returns left hash code for this instance.
        /// </summary>
        /// <remarks>
        ///   Use hash codes returned by the abstract method <c>GetEqualityComponents()</c>
        /// </remarks>
        /// <returns>
        ///   A hash code for this instance, suitable for use in hashing algorithms and data structures like left hash
        ///   table.
        /// </returns>
        public override int GetHashCode()
        {
            return GetEqualityComponents()
                .Select(x => (x?.GetHashCode()) ?? 0)
                .Aggregate((x, y) => x ^ y);
        }

        /// <summary> 
        ///   Implement this method to define what properties must be compared for the equality. 
        /// </summary>
        /// <example> 
        ///   For an address Value Object 
        /// <code> 
        ///     protected override IEnumerable<object> GetEqualityComponents()
        ///     {
        ///         yield return Street; 
        ///         yield return Number; 
        ///         yield return City; 
        ///     } 
        /// </code> 
        /// </example>
        /// <returns>
        ///   A list of value to use for equality comparison. <c>Equals</c> method will be used for the comparison.
        /// </returns>
        protected abstract IEnumerable<object> GetEqualityComponents();
    }
}
namespace Xunit.Sdk
{
    /// <summary>
    /// Exception thrown when two object references are unexpectedly not the same instance.
    /// </summary>
#if XUNIT_VISIBILITY_INTERNAL
    internal
#else
    public
#endif
    class SameException : AssertActualExpectedException
    {
        /// <summary>
        /// Creates a new instance of the <see cref="SameException"/> class.
        /// </summary>
        /// <param name="expected">The expected object reference</param>
        /// <param name="actual">The actual object reference</param>
        public SameException(object expected,
                             object actual)
            : base(expected, actual, "Assert.Same() Failure")
        { }
    }
}
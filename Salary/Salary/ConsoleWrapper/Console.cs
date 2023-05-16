namespace Salary.ConsoleWrapper
{
    /// <summary>
    /// <see cref="System.Console"/> wrapper.
    /// </summary>
    internal class Console : IConsole
    {
        /// <summary>Writes the specified string value, followed by the current line terminator, to the standard output stream.</summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public void WriteLine(string value) => System.Console.WriteLine(value);

        /// <summary>Reads the next line of characters from the standard input stream.</summary>
        /// <returns>The next line of characters from the input stream, or <see langword="null" /> if no more lines are available.</returns>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to allocate a buffer for the returned string.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The number of characters in the next line of characters is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
        public string ReadLine() => System.Console.ReadLine();
    }
}

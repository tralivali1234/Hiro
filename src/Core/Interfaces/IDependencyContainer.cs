﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hiro.Interfaces
{
    /// <summary>
    /// Represents a type that maps a service dependency to its corresponding type implementation.
    /// </summary>
    public interface IDependencyContainer
    {
        /// <summary>
        /// Determines whether or not a particular service dependency exists in the current dependency container.
        /// </summary>
        /// <param name="dependency">The target service dependency.</param>
        /// <returns><c>true</c> if the service exists; otherwise, it will return <c>false</c>.</returns>
        bool Contains(IDependency dependency);

        /// <summary>
        /// Gets the current list of implementations for the current dependency.
        /// </summary>
        /// <param name="targetDependency">The target dependency.</param>
        /// <param name="addIncompleteImplementations">A boolean flag that determines whether or not the resulting list should include implementations with incomplete dependencies.</param>
        /// <returns>A list of implementations.</returns>
        IEnumerable<IImplementation> GetImplementations(IDependency targetDependency, bool addIncompleteImplementations);
    }
}

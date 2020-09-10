﻿/*
 * This file is part of the CatLib package.
 *
 * (c) CatLib <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: https://catlib.io/
 */

namespace CatLib
{
    /// <summary>
    /// Indicates that the framework ready.
    /// </summary>
    public class StartCompletedEventArgs : ApplicationEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="application">The application instance.</param>
        public StartCompletedEventArgs(IApplication application)
            : base(application)
        {
        }
    }
}

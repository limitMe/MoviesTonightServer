using System;
using System.Collections.Generic;

using MoviesTonight.Models;

namespace MoviesTonight.Support
{
    public class BasicInfo
    {
        private static readonly BasicInfo instance = new BasicInfo();

		static BasicInfo()
		{
		}

		private BasicInfo()
		{
		}

		public static BasicInfo Instance
		{
			get
			{
				return instance;
			}
		}

        public List<MovieInfo> movies = new List<MovieInfo>();
    }
}

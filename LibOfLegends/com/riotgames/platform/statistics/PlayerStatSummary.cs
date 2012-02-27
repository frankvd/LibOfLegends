﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.statistics
{
	public class PlayerStatSummary : AbstractDomainObject
	{
		public PlayerStatSummary()
		{
		}

		public int userId;
		public int maxRating;
		public int leaves;
		public DateTime modifyDate;
		public int losses;
		public int rating;
		public int wins;
		public string playerStatSummaryType;
		public string playerStatSummaryTypeString;
		public SummaryAggStats aggregatedStats;
		public object aggregatedStatsJson;
	}
}

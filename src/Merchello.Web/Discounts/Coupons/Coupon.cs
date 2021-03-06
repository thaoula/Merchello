﻿namespace Merchello.Web.Discounts.Coupons
{
    using System.Collections.Generic;

    using Merchello.Core.Marketing.Discounts;
    using Merchello.Core.Marketing.Offer;
    using Merchello.Core.Marketing.Rewards;
    using Merchello.Core.Models.Interfaces;

    /// <summary>
    /// Represents a discount Coupon.
    /// </summary>
    public class Coupon : OfferBase, ICoupon
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Coupon"/> class.
        /// </summary>
        /// <param name="settings">
        /// The <see cref="IOfferSettings"/>.
        /// </param>
        public Coupon(IOfferSettings settings)
            : base(settings)
        {
        }

        public IEnumerable<DiscountConstraintBase> Constraints { get; private set; }

        public IEnumerable<RewardBase> Rewards { get; private set; }
    }
}
﻿// <auto-generated>
// This file was generated automatically by GenerateFromSchema. Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer
// </auto-generated>

using CesiumLanguageWriter.Advanced;
using System;
using JetBrains.Annotations;
using System.Collections.Generic;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>DistanceDisplayCondition</c> to a <see cref="CesiumOutputStream"/>. A <c>DistanceDisplayCondition</c> is indicates the visibility of an object based on the distance to the camera.
    /// </summary>
    public class DistanceDisplayConditionCesiumWriter : CesiumInterpolatablePropertyWriter<DistanceDisplayConditionCesiumWriter>, ICesiumDeletablePropertyWriter, ICesiumDistanceDisplayConditionValuePropertyWriter, ICesiumReferenceValuePropertyWriter
    {
        /// <summary>
        /// The name of the <c>distanceDisplayCondition</c> property.
        /// </summary>
        public const string DistanceDisplayConditionPropertyName = "distanceDisplayCondition";

        /// <summary>
        /// The name of the <c>reference</c> property.
        /// </summary>
        public const string ReferencePropertyName = "reference";

        /// <summary>
        /// The name of the <c>delete</c> property.
        /// </summary>
        public const string DeletePropertyName = "delete";

        private readonly Lazy<CesiumDistanceDisplayConditionValuePropertyAdaptor<DistanceDisplayConditionCesiumWriter>> m_asDistanceDisplayCondition;
        private readonly Lazy<CesiumReferenceValuePropertyAdaptor<DistanceDisplayConditionCesiumWriter>> m_asReference;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        public DistanceDisplayConditionCesiumWriter([NotNull] string propertyName)
            : base(propertyName)
        {
            m_asDistanceDisplayCondition = CreateAsDistanceDisplayCondition();
            m_asReference = CreateAsReference();
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected DistanceDisplayConditionCesiumWriter([NotNull] DistanceDisplayConditionCesiumWriter existingInstance)
            : base(existingInstance)
        {
            m_asDistanceDisplayCondition = CreateAsDistanceDisplayCondition();
            m_asReference = CreateAsReference();
        }

        /// <inheritdoc/>
        public override DistanceDisplayConditionCesiumWriter Clone()
        {
            return new DistanceDisplayConditionCesiumWriter(this);
        }

        /// <summary>
        /// Writes the value expressed as a <c>distanceDisplayCondition</c>, which is the value specified as two values <c>[NearDistance, FarDistance]</c>, with distances in meters.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteDistanceDisplayCondition(Bounds value)
        {
            const string PropertyName = DistanceDisplayConditionPropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteBounds(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>distanceDisplayCondition</c>, which is the value specified as two values <c>[NearDistance, FarDistance]</c>, with distances in meters.
        /// </summary>
        /// <param name="lowerBound">The lower bound.</param>
        /// <param name="upperBound">The upper bound.</param>
        public void WriteDistanceDisplayCondition(double lowerBound, double upperBound)
        {
            WriteDistanceDisplayCondition(new Bounds(lowerBound, upperBound));
        }

        /// <summary>
        /// Writes the value expressed as a <c>distanceDisplayCondition</c>, which is the value specified as two values <c>[NearDistance, FarDistance]</c>, with distances in meters.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteDistanceDisplayCondition(IList<JulianDate> dates, IList<Bounds> values)
        {
            WriteDistanceDisplayCondition(dates, values, 0, dates.Count);
        }

        /// <summary>
        /// Writes the value expressed as a <c>distanceDisplayCondition</c>, which is the value specified as two values <c>[NearDistance, FarDistance]</c>, with distances in meters.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteDistanceDisplayCondition(IList<JulianDate> dates, IList<Bounds> values, int startIndex, int length)
        {
            const string PropertyName = DistanceDisplayConditionPropertyName;
            OpenIntervalIfNecessary();
            CesiumWritingHelper.WriteBounds(Output, PropertyName, dates, values, startIndex, length);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the value specified as a reference to another property.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteReference(Reference value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the value specified as a reference to another property.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteReference(string value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the value specified as a reference to another property.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteReference(string identifier, string propertyName)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, identifier, propertyName);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the value specified as a reference to another property.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteReference(string identifier, string[] propertyNames)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, identifier, propertyNames);
        }

        /// <summary>
        /// Writes the value expressed as a <c>delete</c>, which is whether the client should delete existing samples or interval data for this property. Data will be deleted for the containing interval, or if there is no containing interval, then all data. If true, all other properties in this property will be ignored.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteDelete(bool value)
        {
            const string PropertyName = DeletePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            Output.WriteValue(value);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumDistanceDisplayConditionValuePropertyWriter"/>. Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close"/> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public CesiumDistanceDisplayConditionValuePropertyAdaptor<DistanceDisplayConditionCesiumWriter> AsDistanceDisplayCondition()
        {
            return m_asDistanceDisplayCondition.Value;
        }

        private Lazy<CesiumDistanceDisplayConditionValuePropertyAdaptor<DistanceDisplayConditionCesiumWriter>> CreateAsDistanceDisplayCondition()
        {
            return new Lazy<CesiumDistanceDisplayConditionValuePropertyAdaptor<DistanceDisplayConditionCesiumWriter>>(CreateDistanceDisplayCondition, false);
        }

        private CesiumDistanceDisplayConditionValuePropertyAdaptor<DistanceDisplayConditionCesiumWriter> CreateDistanceDisplayCondition()
        {
            return CesiumValuePropertyAdaptors.CreateDistanceDisplayCondition(this);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumReferenceValuePropertyWriter"/>. Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close"/> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public CesiumReferenceValuePropertyAdaptor<DistanceDisplayConditionCesiumWriter> AsReference()
        {
            return m_asReference.Value;
        }

        private Lazy<CesiumReferenceValuePropertyAdaptor<DistanceDisplayConditionCesiumWriter>> CreateAsReference()
        {
            return new Lazy<CesiumReferenceValuePropertyAdaptor<DistanceDisplayConditionCesiumWriter>>(CreateReference, false);
        }

        private CesiumReferenceValuePropertyAdaptor<DistanceDisplayConditionCesiumWriter> CreateReference()
        {
            return CesiumValuePropertyAdaptors.CreateReference(this);
        }

    }
}

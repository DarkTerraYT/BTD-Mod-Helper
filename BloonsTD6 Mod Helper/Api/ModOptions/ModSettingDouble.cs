﻿using System;
using Il2CppTMPro;
namespace BTD_Mod_Helper.Api.ModOptions;

/// <summary>
/// ModSetting for a decimal value
/// </summary>
public class ModSettingDouble : ModSettingNumber<double>
{

    /// <summary>
    /// Old way of doing slider
    /// </summary>
    [Obsolete("Use slider instead")]
    public bool isSlider;

    /// <summary>
    /// Old way of doing max
    /// </summary>
    [Obsolete("Use max instead")]
    public double? maxValue;
    /// <summary>
    /// Old way of doing min
    /// </summary>
    [Obsolete("Use min instead")]
    public double? minValue;

    /// <summary>
    /// Step size to use for slider, or how much to round the input
    /// </summary>
    public float stepSize = .01f;

    /// <summary>
    /// Maximum digits of precision to round to
    /// </summary>
    public int precisionDigits = 3;

    /// <inheritdoc />
    public ModSettingDouble(double value) : base(value)
    {
    }

    /// <inheritdoc />
    protected override TMP_InputField.CharacterValidation Validation => TMP_InputField.CharacterValidation.Decimal;

    /// <inheritdoc />
    protected override float StepSize => stepSize;

    /// <summary>
    /// Constructs a new ModSetting with the given value as default
    /// </summary>
    public static implicit operator ModSettingDouble(double value) => new(value);
    
    /// <summary>
    /// Constructs a new ModSetting with the given value as default
    /// </summary>
    public static implicit operator ModSettingDouble(float value) => new(value);

    /// <summary>
    /// Gets the current value out of a ModSetting
    /// </summary>
    public static implicit operator double(ModSettingDouble modSettingDouble) => modSettingDouble.value;

    /// <summary>
    /// Gets the current value out of a ModSetting
    /// </summary>
    public static implicit operator float(ModSettingDouble modSettingDouble) => (float) modSettingDouble.value;

    /// <inheritdoc />
    protected override string ToString(double input) => Math.Round(Math.Round(input / stepSize) * stepSize, precisionDigits).ToString();

    /// <inheritdoc />
    protected override double FromString(string s) => double.TryParse(s, out var result) ? result : 0;

    /// <inheritdoc />
    protected override float ToFloat(double input) => (float) input;

    /// <inheritdoc />
    protected override double FromFloat(float f) => f;
}
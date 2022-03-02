using Microsoft.AspNetCore.Components;
using System.ComponentModel;

namespace PromobBlazorServer.Components
{
    #region Enums

    public enum Adornment
    {
        None = 0,
        Start = 1,
        End = 2
    }
    public enum Align
    {
        Inherit,
        Left,
        Center,
        Right,
        Justify,
        Start,
        End
    }
    public enum Animation
    {
        False,
        Pulse,
        Wave
    }
    public enum Color
    {
        Default = 0,
        Primary = 1,
        Secondary = 2,
        Tertiary = 3,
        Info = 4,
        Success = 5,
        Warning = 6,
        Error = 7,
        Dark = 8,
        Transparent = 9,
        Inherit = 10,
        Surface = 11
    }
    public enum Elevation
    {
        None = 0,
        Min = 1,
        Small = 6,
        Medium = 12,
        Large = 18,
        Max = 24
    }
    public enum GridType
    {
        None,
        _1Column,
        _1ColumnWidth3,
        _1ColumnWidth4,
        _1ColumnWidth5,
        _1ColumnWidth6,
        _1ColumnWidth7,
        _1ColumnWidth8,
        _1ColumnWidth9,
        _1ColumnWidth10,
        _2Columns,
        _2ColumnsWidth2x10,
        _2ColumnsWidth3x9,
        _2ColumnsWidth4x8,
        _2ColumnsWidth5x7,
        _3Columns,
        _4Columns,
        _5Columns,
        _6Columns
    }
    public enum Justify
    {
        FlexStart = 0,
        Center = 1,
        FlexEnd = 2,
        SpaceBetween = 3,
        SpaceAround = 4,
        SpaceEvenly = 5
    }
    public enum MaxWidth
    {
        Large = 0,
        Medium = 1,
        Small = 2,
        ExtraLarge = 3,
        ExtraExtraLarge = 4,
        ExtraSmall = 5,
        False = 6
    }
    public enum PageMode
    {
        Search,
        Edit
    }
    public enum ProgressType
    {
        Circular,
        Linear
    }
    public enum Size
    {
        Small,
        Medium,
        Large
    }
    public enum SkeletonType
    {
        Text,
        Circle,
        Rectangle
    }
    public enum Typo
    {
        Inherit = 0,
        H1 = 1,
        H2 = 2,
        H3 = 3,
        H4 = 4,
        H5 = 5,
        H6 = 6,
        Subtitle1 = 7,
        Subtitle2 = 8,
        Body1 = 9,
        Body2 = 10,
        Button = 11,
        Caption = 12,
        Overline = 13
    }
    public enum WidthType
    {
        Xs,
        Sm,
        Md,
        Lg,
        Xl,
        Xxl
    }

    #endregion

    #region Style

    public enum AlignItems
    {
        [Description("")]
        _None,
        Baseline,
        Center,
        End,
        [Description("flex-end")]
        FlexEnd,
        [Description("flex-start")]
        FlexStart,
        Inherit,
        Initial,
        Normal,
        Revert,
        [Description("self-end")]
        SelfEnd,
        [Description("self-start")]
        SelfStart,
        Start,
        Stretch,
        Unset
    }
    public enum Position
    {
        [Description("")]
        _None,
        Absolute,
        Fixed,
        Inherit,
        Initial,
        Relative,
        Revert,
        Static,
        Sticky,
        Unset
    }
    public enum TextAlign
    {
        [Description("")]
        _None,
        Inherit,
        Center,
        End,
        Initial,
        Justify,
        Left,
        Revert,
        Right,
        Start,
        Unset,
        [Description("-webkit-auto")]
        WebkitAuto,
        [Description("-webkit-center")]
        WebkitCenter,
        [Description("-webkit-left")]
        WebkitLeft,
        [Description("-webkit-match-parent")]
        WebkitMatchParent,
        [Description("-webkit-right")]
        WebkitRight
    }
    public enum JustifyContent
    {
        [Description("")]
        _None,
        [Description("flex-start")]
        FlexStart,
        [Description("flex-end")]
        FlexEnd,
        Center,
        [Description("space-between")]
        SpaceBetween,
        [Description("space-around")]
        SpaceAround,
        [Description("space-evenly")]
        SpaceEvenly,
        Initial,
        Inherit
    }
    public enum Cursor
    {
        [Description("")]
        _None,
        Alias,
        [Description("all-scroll")]
        AllScroll,
        Auto,
        Cell,
        [Description("col-resize")]
        ColResize,
        [Description("context-menu")]
        ContextMenu,
        Copy,
        Crosshair,
        Default,
        [Description("e-resize")]
        EResize,
        [Description("ew-resize")]
        EWResize,
        Grab,
        Grabbing,
        Help,
        Inherit,
        Initial,
        Move,
        [Description("n-resize")]
        NResize,
        [Description("ne-resize")]
        NEResize,
        [Description("nesw-resize")]
        NESWResize,
        [Description("no-drop")]
        NoDrop,
        None,
        [Description("not-allowed")]
        NotAllowed,
        [Description("ns-resize")]
        NSResize,
        [Description("nw-resize")]
        NWResize,
        [Description("nwse-resize")]
        NWSEResize,
        Pointer,
        Progress,
        Revert,
        [Description("row-resize")]
        RowResize,
        [Description("s-resize")]
        SResize,
        [Description("se-resize")]
        SEResize,
        [Description("sw-resize")]
        SWResize,
        Text,
        Unset,
        [Description("vertical-text")]
        VerticalText,
        [Description("w-resize")]
        WResize,
        Wait,
        [Description("zoom-in")]
        ZoomIn,
        [Description("zoom-out")]
        ZoomOut,
        [Description("-webkit-grab")]
        WebkitGrab,
        [Description("-webkit-grabbing")]
        WebkitGrabbing,
        [Description("-webkit-zoom-in")]
        WebkitZoomIn,
        [Description("-webkit-grab")]
        WebkitZoomOut
    }
    public enum Display
    {
        [Description("")]
        _None,
        Block,
        Contents,
        Flex,
        [Description("flex-root")]
        FlowRoot,
        Grid,
        Inherit,
        Initial,
        Inline,
        [Description("inline-block")]
        InlineBlock,
        [Description("inline-flex")]
        InlineFlex,
        [Description("inline-grid")]
        InlineGrid,
        [Description("inline-table")]
        InlineTable,
        [Description("list-item")]
        ListItem,
        None,
        Revert,
        Table,
        [Description("table-caption")]
        TableCaption,
        [Description("table-cell")]
        TableCell,
        [Description("table-column")]
        TableColumn,
        [Description("table-column-group")]
        TableColumnGroup,
        [Description("table-footer-group")]
        TableFooterGroup,
        [Description("table-header-group")]
        TableHeaderGroup,
        [Description("table-row")]
        TableRow,
        [Description("table-row-group")]
        TableRowGroup,
        Unset,
        [Description("-webkit-box")]
        WebkitBox,
        [Description("-webkit-inline-box")]
        WebkitInlineBox
    }
    public enum Overflow
    {
        [Description("")]
        _None,
        Auto,
        Hidden,
        Inherit,
        Initial,
        Overlay,
        Revert,
        Scroll,
        Unset,
        Visible
    }
    public enum OverflowWrap
    {
        [Description("")]
        _None,
        Anywhere,
        [Description("break-word")]
        BreakWord,
        Inherit,
        Initial,
        Normal,
        Revert,
        Unset
    }
    public enum TextTransform
    {
        [Description("")]
        _None,
        Capitalize,
        Inherit,
        Initial,
        Lowercase,
        [Description("math-auto")]
        MathAuto,
        None,
        Revert,
        Upset,
        Uppercase
    }
    public enum VerticalAlign
    {
        [Description("")]
        _None,
        Baseline,
        Bottom,
        Inherit,
        Initial,
        Middle,
        Revert,
        Sub,
        Super,
        [Description("text-bottom")]
        TextBottom,
        [Description("text-top")]
        TextTop,
        Top,
        Unset,
        [Description("-webkit-baseline-middle")]
        WebkitBaselineMiddle
    }
    public enum WhiteSpace
    {
        [Description("")]
        _None,
        [Description("break-spaces")]
        BreakSpaces,
        Inherit,
        Initial,
        None,
        Normal,
        Nowrap,
        Pre,
        [Description("pre-line")]
        PreLine,
        [Description("pre-wrap")]
        PreWrap,
        Revert,
        Unset,
        [Description("-webkit-nowrap")]
        WebkitNowrap
    }
    public enum WordBreak
    {
        [Description("")]
        _None,
        [Description("break-all")]
        BreakAll,
        [Description("break-word")]
        BreakWord,
        Inherit,
        Initial,
        [Description("keep-all")]
        KeepAll,
        Normal,
        Revert,
        Unset
    }

    public class PromobStyle
    {
        #region Attributes

        public string? Style { get; set; }
        public int? Margin { get; set; }
        public string? MarginString { get; set; }
        public int? MarginLeft { get; set; }
        public int? MarginTop { get; set; }
        public int? MarginRight { get; set; }
        public int? MarginBottom { get; set; }
        public int? Padding { get; set; }
        public int? PaddingLeft { get; set; }
        public int? PaddingTop { get; set; }
        public int? PaddingRight { get; set; }
        public int? PaddingBottom { get; set; }
        public TextAlign TextAlign { get; set; }
        public JustifyContent JustifyContent { get; set; }
        public AlignItems AlignItems { get; set; }
        public Position Position { get; set; }
        public string? Top { get; set; }
        public string? Left { get; set; }
        public string? Right { get; set; }
        public string? Bottom { get; set; }
        public string? ZIndex { get; set; }
        public string? Opacity { get; set; }
        public string? BackgroundColor { get; set; }
        public string? BackgroundImage { get; set; }
        public string? Border { get; set; }
        public string? Color { get; set; }
        public Cursor Cursor { get; set; }
        public Display Display { get; set; }
        public string? FontFamily { get; set; }
        public string? FontSize { get; set; }
        public bool FontBold { get; set; }
        public string? MaxHeight { get; set; }
        public string? MaxWidth { get; set; }
        public string? MinHeight { get; set; }
        public string? MinWidth { get; set; }
        public Overflow Overflow { get; set; }
        public OverflowWrap OverflowWrap { get; set; }
        public bool DisableMousePointerEvents { get; set; }
        public bool TextUnderline { get; set; }
        public TextTransform TextTransform { get; set; }
        public VerticalAlign VerticalAlign { get; set; }
        public bool VisibilityHidden { get; set; }
        public WhiteSpace WhiteSpace { get; set; }
        public string? Height { get; set; }
        public string? Width { get; set; }
        public WordBreak WordBreak { get; set; }

        #endregion

        public string BuildStyle()
        {
            List<string> style = new List<string>();
            if (!string.IsNullOrWhiteSpace(Style))
                style.AddRange(Style.Split(';'));

            if (Margin.HasValue) style.Add($"margin: {Margin.Value}px !important");
            if (!string.IsNullOrWhiteSpace(MarginString)) style.Add($"margin: {MarginString} !important");
            if (MarginBottom.HasValue) style.Add($"margin-bottom: {MarginBottom.Value}px !important");
            if (MarginLeft.HasValue) style.Add($"margin-left: {MarginLeft.Value}px !important");
            if (MarginRight.HasValue) style.Add($"margin-right: {MarginRight.Value}px !important");
            if (MarginTop.HasValue) style.Add($"margin-top: {MarginTop.Value}px !important");
            if (Padding.HasValue) style.Add($"padding: {Padding.Value}px !important");
            if (PaddingBottom.HasValue) style.Add($"padding-bottom: {PaddingBottom.Value}px !important");
            if (PaddingLeft.HasValue) style.Add($"padding-left: {PaddingLeft.Value}px !important");
            if (PaddingRight.HasValue) style.Add($"padding-right: {PaddingRight.Value}px !important");
            if (PaddingTop.HasValue) style.Add($"padding-top: {PaddingTop.Value}px !important");
            if (TextAlign != TextAlign._None) style.Add($"text-align: {TextAlign.ToDescriptionString()} !important");
            if (AlignItems != AlignItems._None) style.Add($"align-items: {AlignItems.ToDescriptionString()} !important");
            if (Position != Position._None) style.Add($"position: {Position.ToDescriptionString()} !important");
            if (!string.IsNullOrWhiteSpace(Top)) style.Add($"top: {Top} !important");
            if (!string.IsNullOrWhiteSpace(Left)) style.Add($"left: {Left} !important");
            if (!string.IsNullOrWhiteSpace(Right)) style.Add($"right: {Right} !important");
            if (!string.IsNullOrWhiteSpace(Bottom)) style.Add($"bottom: {Bottom} !important");
            if (!string.IsNullOrWhiteSpace(ZIndex)) style.Add($"z-index: {ZIndex} !important");
            if (!string.IsNullOrWhiteSpace(Opacity)) style.Add($"opacity: {Opacity} !important");
            if (!string.IsNullOrWhiteSpace(BackgroundColor)) style.Add($"background-color: {BackgroundColor} !important");
            if (!string.IsNullOrWhiteSpace(BackgroundImage)) style.Add($"background-image: {BackgroundImage} !important");
            if (!string.IsNullOrWhiteSpace(Border)) style.Add($"border: {Border} !important");
            if (!string.IsNullOrWhiteSpace(Color)) style.Add($"color: {Color} !important");
            if (Cursor != Cursor._None) style.Add($"cursor: {Cursor.ToDescriptionString()} !important");
            if (Display != Display._None) style.Add($"display: {Display.ToDescriptionString()} !important");
            if (!string.IsNullOrWhiteSpace(FontFamily)) style.Add($"font-family: {FontFamily} !important");
            if (!string.IsNullOrWhiteSpace(FontSize)) style.Add($"font-size: {FontSize} !important");
            if (FontBold) style.Add("font-weight: bold !important");
            if (!string.IsNullOrWhiteSpace(MaxHeight)) style.Add($"max-height: {MaxHeight} !important");
            if (!string.IsNullOrWhiteSpace(MaxWidth)) style.Add($"max-width: {MaxWidth} !important");
            if (!string.IsNullOrWhiteSpace(MinHeight)) style.Add($"min-height: {MinHeight} !important");
            if (!string.IsNullOrWhiteSpace(MinWidth)) style.Add($"min-width: {MinWidth} !important");
            if (Overflow != Overflow._None) style.Add($"overflow: {Overflow.ToDescriptionString()} !important");
            if (OverflowWrap != OverflowWrap._None) style.Add($"overflow-wrap: {OverflowWrap.ToDescriptionString()} !important");
            if (DisableMousePointerEvents) style.Add("pointer-events: none !important");
            if (TextUnderline) style.Add("text-decoration: underline !important");
            if (TextTransform != TextTransform._None) style.Add($"text-transform: {TextTransform.ToDescriptionString()} !important");
            if (VerticalAlign != VerticalAlign._None) style.Add($"vertical-align: {VerticalAlign.ToDescriptionString()} !important");
            if (VisibilityHidden) style.Add($"visibility: hidden !important");
            if (WhiteSpace != WhiteSpace._None) style.Add($"white-space: {WhiteSpace.ToDescriptionString()} !important");
            if (!string.IsNullOrWhiteSpace(Height)) style.Add($"height: {Height} !important");
            if (!string.IsNullOrWhiteSpace(Width)) style.Add($"width: {Width} !important");
            if (WordBreak != WordBreak._None) style.Add($"word-break: {WordBreak.ToDescriptionString()} !important");
            if (JustifyContent != JustifyContent._None) style.Add($"justify-content: {JustifyContent.ToDescriptionString()} !important");

            return string.Join("; ", style);
        }
    }

    #endregion

    public static class PromobEnums
    {
        public static MudBlazor.Adornment GetAdornment(Adornment adornment)
        {
            switch (adornment)
            {
                case Adornment.End: return MudBlazor.Adornment.End;
                case Adornment.Start: return MudBlazor.Adornment.Start;
                default: return MudBlazor.Adornment.None;
            }
        }
        public static MudBlazor.Align GetAlign(Align align)
        {
            switch (align)
            {
                case Align.Center: return MudBlazor.Align.Center;
                case Align.Right: return MudBlazor.Align.Right;
                case Align.End: return MudBlazor.Align.End;
                case Align.Inherit: return MudBlazor.Align.Inherit;
                case Align.Start: return MudBlazor.Align.Start;
                case Align.Justify: return MudBlazor.Align.Justify;
                default: return MudBlazor.Align.Left;
            }
        }
        public static MudBlazor.Animation GetAnimation(Animation animation)
        {
            switch (animation)
            {
                case Animation.False: return MudBlazor.Animation.False;
                case Animation.Wave: return MudBlazor.Animation.Wave;
                default: return MudBlazor.Animation.Pulse;
            }
        }
        public static MudBlazor.SkeletonType GetSkeletonType(SkeletonType skeletonType)
        {
            switch (skeletonType)
            {
                case SkeletonType.Circle: return MudBlazor.SkeletonType.Circle;
                case SkeletonType.Text: return MudBlazor.SkeletonType.Text;
                default: return MudBlazor.SkeletonType.Rectangle;
            }
        }
        public static MudBlazor.Color GetColor(Color color)
        {
            switch (color)
            {
                case Color.Dark: return MudBlazor.Color.Dark;
                case Color.Error: return MudBlazor.Color.Error;
                case Color.Info: return MudBlazor.Color.Info;
                case Color.Inherit: return MudBlazor.Color.Inherit;
                case Color.Primary: return MudBlazor.Color.Primary;
                case Color.Secondary: return MudBlazor.Color.Secondary;
                case Color.Success: return MudBlazor.Color.Success;
                case Color.Surface: return MudBlazor.Color.Surface;
                case Color.Tertiary: return MudBlazor.Color.Tertiary;
                case Color.Transparent: return MudBlazor.Color.Transparent;
                case Color.Warning: return MudBlazor.Color.Warning;
                default: return MudBlazor.Color.Default;
            }
        }
        public static int GetElevation(Elevation elevation)
        {
            switch (elevation)
            {
                case Elevation.Min: return 1;
                case Elevation.Small: return 6;
                case Elevation.Medium: return 12;
                case Elevation.Large: return 18;
                case Elevation.Max: return 24;
                default: return 0;
            }
        }
        public static MudBlazor.Justify GetJustify(Justify justify)
        {
            switch (justify)
            {
                case Justify.Center: return MudBlazor.Justify.Center;
                case Justify.SpaceAround: return MudBlazor.Justify.SpaceAround;
                case Justify.SpaceBetween: return MudBlazor.Justify.SpaceBetween;
                case Justify.SpaceEvenly: return MudBlazor.Justify.SpaceEvenly;
                case Justify.FlexEnd: return MudBlazor.Justify.FlexEnd;
                default: return MudBlazor.Justify.FlexStart;
            }
        }
        public static MudBlazor.MaxWidth GetMaxWidth(MaxWidth maxWidth)
        {
            switch (maxWidth)
            {
                case MaxWidth.ExtraExtraLarge: return MudBlazor.MaxWidth.ExtraExtraLarge;
                case MaxWidth.ExtraLarge: return MudBlazor.MaxWidth.ExtraLarge;
                case MaxWidth.ExtraSmall: return MudBlazor.MaxWidth.ExtraSmall;
                case MaxWidth.Large: return MudBlazor.MaxWidth.Large;
                case MaxWidth.Medium: return MudBlazor.MaxWidth.Medium;
                case MaxWidth.Small: return MudBlazor.MaxWidth.Small;
                default: return MudBlazor.MaxWidth.False;
            }
        }
        public static MudBlazor.Typo GetTypo(Typo typo)
        {
            switch (typo)
            {
                case Typo.Body1: return MudBlazor.Typo.body1;
                case Typo.Body2: return MudBlazor.Typo.body2;
                case Typo.Button: return MudBlazor.Typo.button;
                case Typo.Caption: return MudBlazor.Typo.caption;
                case Typo.H1: return MudBlazor.Typo.h1;
                case Typo.H2: return MudBlazor.Typo.h2;
                case Typo.H3: return MudBlazor.Typo.h3;
                case Typo.H4: return MudBlazor.Typo.h4;
                case Typo.H5: return MudBlazor.Typo.h5;
                case Typo.H6: return MudBlazor.Typo.h6;
                case Typo.Overline: return MudBlazor.Typo.overline;
                case Typo.Subtitle1: return MudBlazor.Typo.subtitle1;
                case Typo.Subtitle2: return MudBlazor.Typo.subtitle2;
                default: return MudBlazor.Typo.inherit;
            }
        }
        public static MudBlazor.Size GetSize(Size size)
        {
            switch (size)
            {
                case Size.Large: return MudBlazor.Size.Large;
                case Size.Small: return MudBlazor.Size.Small;
                default: return MudBlazor.Size.Medium;
            }
        }
    }

    public static class PromobEnumsExtensions
    {
        public static string ToDescriptionString(this Enum val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0
                ? attributes[0].Description
                : val.ToString().ToLower();
        }
    }

    public abstract class PromobBaseComponent : ComponentBase
    {
        /// <summary>
        /// UserAttributes carries all attributes you add to the component that don't match any of its parameters. They will be splatted onto the underlying HTML tag. Default: null
        /// </summary>
        [Parameter(CaptureUnmatchedValues = true)]
        public virtual Dictionary<string, object>? UserAttributes { get; set; }

        /// <summary>
        /// Child Content of the component.
        /// </summary>
        [Parameter] public virtual RenderFragment? ChildContent { get; set; }

        /// <summary>
        /// Use Tag to attach any user data object to the component for your convenience. Default: null
        /// </summary>
        [Parameter] public virtual object? Tag { get; set; } = null;

        /// <summary>
        /// Value in pixels (px) to be added in the "margin" property of style. Default: null
        /// </summary>
        [Parameter] public virtual int? StyleMargin { get; set; }

        /// <summary>
        /// Value to be added in the "margin" property of style. Default: string.Empty;
        /// </summary>
        [Parameter] public virtual string StyleMarginString { get; set; } = string.Empty;

        /// <summary>
        /// Value in pixels (px) to be added in the "margin-left" property of style. Default: null
        /// </summary>
        [Parameter] public virtual int? StyleMarginLeft { get; set; }

        /// <summary>
        /// Value in pixels (px) to be added in the "margin-top" property of style. Default: null
        /// </summary>
        [Parameter] public virtual int? StyleMarginTop { get; set; }

        /// <summary>
        /// Value in pixels (px) to be added in the "margin-right" property of style. Default: null
        /// </summary>
        [Parameter] public virtual int? StyleMarginRight { get; set; }

        /// <summary>
        /// Value in pixels (px) to be added in the "margin-bottom" property of style. Default: null
        /// </summary>
        [Parameter] public virtual int? StyleMarginBottom { get; set; }

        /// <summary>
        /// Value in pixels (px) to be added in the "padding" property of style. Default: null
        /// </summary>
        [Parameter] public virtual int? StylePadding { get; set; }

        /// <summary>
        /// Value in pixels (px) to be added in the "padding-left" property of style. Default: null
        /// </summary>
        [Parameter] public virtual int? StylePaddingLeft { get; set; }

        /// <summary>
        /// Value in pixels (px) to be added in the "padding-top" property of style. Default: null
        /// </summary>
        [Parameter] public virtual int? StylePaddingTop { get; set; }

        /// <summary>
        /// Value in pixels (px) to be added in the "padding-right" property of style. Default: null
        /// </summary>
        [Parameter] public virtual int? StylePaddingRight { get; set; }

        /// <summary>
        /// Value in pixels (px) to be added in the "padding-bottom" property of style. Default: null
        /// </summary>
        [Parameter] public virtual int? StylePaddingBottom { get; set; }

        /// <summary>
        /// Value to be added in the "text-align" property of style. Default: TextAlign._None
        /// </summary>
        [Parameter] public virtual TextAlign StyleTextAlign { get; set; } = TextAlign._None;

        /// <summary>
        /// Value to be added in the "justfy-content" property of style. Default: JustifyContent._None
        /// </summary>
        [Parameter] public virtual JustifyContent StyleJustifyContent { get; set; } = JustifyContent._None;

        /// <summary>
        /// Value to be added in the "align-items" property of style. Default: AlignItems._None
        /// </summary>
        [Parameter] public virtual AlignItems StyleAlignItems { get; set; } = AlignItems._None;

        /// <summary>
        /// Value to be added in the "position" property of style. Default: Position._None
        /// </summary>
        [Parameter] public virtual Position StylePosition { get; set; } = Position._None;

        /// <summary>
        /// Value to be added in the "top" property of style. Default: string.Empty;
        /// </summary>
        [Parameter] public virtual string StyleTop { get; set; } = string.Empty;

        /// <summary>
        /// Value to be added in the "left" property of style. Default: string.Empty;
        /// </summary>
        [Parameter] public virtual string StyleLeft { get; set; } = string.Empty;

        /// <summary>
        /// Value to be added in the "right" property of style. Default: string.Empty;
        /// </summary>
        [Parameter] public virtual string StyleRight { get; set; } = string.Empty;

        /// <summary>
        /// Value to be added in the "bottom" property of style. Default: string.Empty;
        /// </summary>
        [Parameter] public virtual string StyleBottom { get; set; } = string.Empty;

        /// <summary>
        /// Value to be added in the "z-index" property of style. Default: string.Empty;
        /// </summary>
        [Parameter] public virtual string StyleZIndex { get; set; } = string.Empty;

        /// <summary>
        /// Value to be added in the "opacity" property of style. Default: string.Empty;
        /// </summary>
        [Parameter] public virtual string StyleOpacity { get; set; } = string.Empty;

        /// <summary>
        /// Value to be added in the "background-color" property of style. Default: string.Empty;
        /// </summary>
        [Parameter] public virtual string StyleBackgroundColor { get; set; } = string.Empty;

        /// <summary>
        /// Value to be added in the "background-image" property of style. Default: string.Empty;
        /// </summary>
        [Parameter] public virtual string StyleBackgroundImage { get; set; } = string.Empty;

        /// <summary>
        /// Value to be added in the "border" property of style. Default: string.Empty;
        /// </summary>
        [Parameter] public virtual string StyleBorder { get; set; } = string.Empty;

        /// <summary>
        /// Value to be added in the "color" property of style. Default: string.Empty;
        /// </summary>
        [Parameter] public virtual string StyleColor { get; set; } = string.Empty;

        /// <summary>
        /// Value to be added in the "cursor" property of style. Default: Cursor._None
        /// </summary>
        [Parameter] public virtual Cursor StyleCursor { get; set; } = Cursor._None;

        /// <summary>
        /// Value to be added in the "display" property of style. Default: Display._None
        /// </summary>
        [Parameter] public virtual Display StyleDisplay { get; set; } = Display._None;

        /// <summary>
        /// Value to be added in the "font-family" property of style. Default: string.Empty;
        /// </summary>
        [Parameter] public virtual string StyleFontFamily { get; set; } = string.Empty;

        /// <summary>
        /// Value to be added in the "font-size" property of style. Default: string.Empty;
        /// </summary>
        [Parameter] public virtual string StyleFontSize { get; set; } = string.Empty;

        /// <summary>
        /// If true, "font-weight: bold" will be added to the style. Default: false
        /// </summary>
        [Parameter] public virtual bool StyleFontBold { get; set; } = false;

        /// <summary>
        /// Value to be added in the "max-height" property of style. Default: string.Empty;
        /// </summary>
        [Parameter] public virtual string StyleMaxHeight { get; set; } = string.Empty;

        /// <summary>
        /// Value to be added in the "max-width" property of style. Default: string.Empty;
        /// </summary>
        [Parameter] public virtual string StyleMaxWidth { get; set; } = string.Empty;

        /// <summary>
        /// Value to be added in the "min-height" property of style. Default: string.Empty;
        /// </summary>
        [Parameter] public virtual string StyleMinHeight { get; set; } = string.Empty;

        /// <summary>
        /// Value to be added in the "min-width" property of style. Default: string.Empty;
        /// </summary>
        [Parameter] public virtual string StyleMinWidth { get; set; } = string.Empty;

        /// <summary>
        /// Value to be added in the "overflow" property of style. Default: Overflow._None
        /// </summary>
        [Parameter] public virtual Overflow StyleOverflow { get; set; } = Overflow._None;

        /// <summary>
        /// Value to be added in the "overflow-wrap" property of style. Default: OverflowWrap._None
        /// </summary>
        [Parameter] public virtual OverflowWrap StyleOverflowWrap { get; set; } = OverflowWrap._None;

        /// <summary>
        /// If true, "pointer-events: none" will be added to the style. Default: false
        /// </summary>
        [Parameter] public virtual bool StyleDisableMousePointerEvents { get; set; } = false;

        /// <summary>
        /// If true, "text-decoration: underline" will be added to the style. Default: false
        /// </summary>
        [Parameter] public virtual bool StyleTextUnderline { get; set; } = false;

        /// <summary>
        /// Value to be added in the "text-transform" property of style. Default: TextTransform._None
        /// </summary>
        [Parameter] public virtual TextTransform StyleTextTransform { get; set; } = TextTransform._None;

        /// <summary>
        /// Value to be added in the "vertical-align" property of style. Default: VerticalAlign._None
        /// </summary>
        [Parameter] public virtual VerticalAlign StyleVerticalAlign { get; set; } = VerticalAlign._None;

        /// <summary>
        /// If true, "visibility: hidden" will be added to the style. Default: false
        /// </summary>
        [Parameter] public virtual bool StyleVisibilityHidden { get; set; } = false;

        /// <summary>
        /// Value to be added in the "white-space" property of style. Default: WhiteSpace._None
        /// </summary>
        [Parameter] public virtual WhiteSpace StyleWhiteSpace { get; set; } = WhiteSpace._None;

        /// <summary>
        /// Value to be added in the "height" property of style. Default: string.Empty;
        /// </summary>
        [Parameter] public virtual string StyleHeight { get; set; } = string.Empty;

        /// <summary>
        /// Value to be added in the "width" property of style. Default: string.Empty
        /// </summary>
        [Parameter] public virtual string StyleWidth { get; set; } = string.Empty;

        /// <summary>
        /// Value to be added in the "word-break" property of style. Default: WordBreak._None
        /// </summary>
        [Parameter] public virtual WordBreak StyleWordBreak { get; set; } = WordBreak._None;

        /// <summary>
        /// Value to be added in the "style" property. Default: string.Empty
        /// </summary>
        [Parameter] public virtual string Style { get; set; } = string.Empty;

        /// <summary>
        /// Value to be added in the "class" property. Default: string.Empty
        /// </summary>
        [Parameter] public virtual string Class { get; set; } = string.Empty;

        public virtual string BuildStyle()
        {
            PromobStyle style = new();
            style.Style = Style;
            style.Margin = StyleMargin;
            style.MarginString = StyleMarginString;
            style.MarginLeft = StyleMarginLeft;
            style.MarginTop = StyleMarginTop;
            style.MarginRight = StyleMarginRight;
            style.MarginBottom = StyleMarginBottom;
            style.Padding = StylePadding;
            style.PaddingLeft = StylePaddingLeft;
            style.PaddingTop = StylePaddingTop;
            style.PaddingRight = StylePaddingRight;
            style.PaddingBottom = StylePaddingBottom;
            style.TextAlign = StyleTextAlign;
            style.AlignItems = StyleAlignItems;
            style.Position = StylePosition;
            style.Top = StyleTop;
            style.Left = StyleLeft;
            style.Right = StyleRight;
            style.Bottom = StyleBottom;
            style.ZIndex = StyleZIndex;
            style.Opacity = StyleOpacity;
            style.BackgroundColor = StyleBackgroundColor;
            style.BackgroundImage = StyleBackgroundImage;
            style.Border = StyleBorder;
            style.Color = StyleColor;
            style.Cursor = StyleCursor;
            style.Display = StyleDisplay;
            style.FontFamily = StyleFontFamily;
            style.FontSize = StyleFontSize;
            style.FontBold = StyleFontBold;
            style.MaxHeight = StyleMaxHeight;
            style.MaxWidth = StyleMaxWidth;
            style.MinHeight = StyleMinHeight;
            style.MinWidth = StyleMinWidth;
            style.Overflow = StyleOverflow;
            style.OverflowWrap = StyleOverflowWrap;
            style.DisableMousePointerEvents = StyleDisableMousePointerEvents;
            style.TextUnderline = StyleTextUnderline;
            style.TextTransform = StyleTextTransform;
            style.VerticalAlign = StyleVerticalAlign;
            style.VisibilityHidden = StyleVisibilityHidden;
            style.WhiteSpace = StyleWhiteSpace;
            style.Height = StyleHeight;
            style.Width = StyleWidth;
            style.WordBreak = StyleWordBreak;
            style.JustifyContent = StyleJustifyContent;
            return style.BuildStyle();
        }
        public virtual async Task RefreshComponent()
        {
            await Task.Delay(1);
            StateHasChanged();
        }
    }
}

﻿/*
    Copyright © 2003 RiskCare Ltd. All rights reserved.
    Copyright © 2010 SvgNet & SvgGdi Bridge Project. All rights reserved.
    Copyright © 2015-2023 Rafael Teixeira, Mojmír Němeček, Benjamin Peterson and Other Contributors

    Original source code licensed with BSD-2-Clause spirit, treat it thus, see accompanied LICENSE for more
*/

namespace SvgNet;
public static class ObjectExtensions {
    public static object CloneIfPossible(this object o) => (o as ICloneable)?.Clone() ?? o;
}

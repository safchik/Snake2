﻿

using System;
using System.Collections.Generic;

namespace Snake2
{
    public class Position
    {
        public int Row {  get; }
        public int Column { get; }

        public Position(int row, int col)
        {
            Row = row;
            Column = col;
        }

        public Position Translate(Direction dir)
        {
            return new Position(Row + dir.RowOffset, Column + dir.ColumnOffset);
        }

        public override bool Equals(object obj)
        {
            return obj is Position position &&
                   Row == position.Row &&
                   Column == position.Column;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Column);
        }

        public static bool operator ==(Position left, Position right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }
    }
}

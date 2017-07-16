﻿using System;
using GoG.Infrastructure.Engine;
using Prism.Windows.Mvvm;

namespace GoG.Board
{
    public class PieceStateViewModel : ViewModelBase
    {
        public PieceStateViewModel(string position, string sequence, GoColor? color,
            bool isHint, bool isNewPiece, bool isNewCapture)
        {
            _position = position;
            _sequence = sequence;
            _color = color;
            _isHint = isHint;
            _isNewPiece = isNewPiece;
            _isNewCapture = isNewCapture;
        }

        public event EventHandler MultiplePropertiesChanged;

        readonly string _position;
        public string Position 
        {
            get { return _position; }
        }

        string _sequence;
        public string Sequence
        {
            get => _sequence; set => SetProperty(ref _sequence, value);
        }

        GoColor? _color;
        public GoColor? Color
        {
            get => _color; set => SetProperty(ref _color, value);
        }

        bool _isHint;
        public bool IsHint
        {
            get => _isHint; set => SetProperty(ref _isHint, value);
        }

        bool _isNewPiece;
        public bool IsNewPiece
        {
            get => _isNewPiece; set => SetProperty(ref _isNewPiece, value);
        }

        bool _isNewCapture;
        public bool IsNewCapture
        {
            get => _isNewCapture; set => SetProperty(ref _isNewCapture, value);
        }

        public void RaiseMultiplePropertiesChanged()
        {
            var e = MultiplePropertiesChanged;
            e?.Invoke(this, null);
        }
    }
}

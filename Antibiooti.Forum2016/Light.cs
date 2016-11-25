using System;

namespace Antibiooti.Forum2016
{
    /// <summary>
    /// Light to be displayed on the console with its status and color
    /// </summary>
    public class Light
    {
        private ConsoleColor _color;
        public Boolean _status;


        /// <summary>
        /// Sets and Gets the Color of the Light Instance
        /// </summary>
        public ConsoleColor Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        /// <summary>
        /// Sets and Gets the Status of the Light Instance
        /// </summary>
        public Boolean Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        /// <summary>
        /// Returning a char depending on the status.
        /// </summary>
        public char getChar(){
            if(_status) {
                return '*';
            }
            else {
                return ' ';
            }
        }

        /// <summary>
        /// Initializes a new instance of the Light class.
        /// </summary>
        public Light(ConsoleColor color, Boolean status)
        {
            this._color = color;
            this._status = status;
        }

        
        /// <summary>
        /// Initializes a new instance of the Light class with no parameters.
        /// </summary>
        public Light()
        {
            this._color = ConsoleColor.White;
            this._status = false;
        }
    }
}
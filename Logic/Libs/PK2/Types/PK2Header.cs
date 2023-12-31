﻿using PK2.IO.Stream;

namespace PK2.Types
{
    /// <summary>
    /// Structure of the PK2 header
    /// {
    ///     30      Bytes   Name
    ///     4       Bytes   Version
    ///     1       Byte    Encrypted
    ///     16      Bytes   SecurityChecksum
    ///     205     Bytes   Reserved
    /// }
    /// </summary>
    public class PK2Header
    {
        #region Properties

        /// <summary>
        /// Gets or sets the header.
        /// </summary>
        /// <value>
        /// The header.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        public byte[] Version { get; set; }

        /// <summary>
        /// Gets or sets the encrypted.
        /// </summary>
        /// <value>
        /// The encrypted.
        /// </value>
        public bool Encrypted { get; set; }

        /// <summary>
        /// Gets or sets the security checksum.
        /// </summary>
        /// <value>
        /// The security checksum.
        /// </value>
        public byte[] SecurityChecksum { get; set; }

        /// <summary>
        /// Gets or sets the unk bytes.
        /// </summary>
        /// <value>
        /// The unk bytes.
        /// </value>
        public byte[] UnkBytes { get; set; }

        #endregion Properties

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PK2Header"/> class.
        /// </summary>
        public PK2Header() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PK2Header"/> class.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <exception cref="SlimPK2.Types.InvalidHeaderException"></exception>
        public PK2Header(byte[] buffer)
        {
            using (var streamWorker = new StreamWorker(buffer, StreamOperation.Read))
            {
                try
                {
                    Name = streamWorker.ReadString(30).Trim('\0');
                    Version = streamWorker.ReadByteArray(4);
                    Encrypted = streamWorker.ReadBool();
                    SecurityChecksum = streamWorker.ReadByteArray(16);
                    UnkBytes = streamWorker.ReadByteArray(205);
                }
                catch
                {
                    throw new InvalidHeaderException();
                }
            }
        }

        #endregion Constructor
    }
}
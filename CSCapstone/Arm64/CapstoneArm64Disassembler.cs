namespace CSCapstone.Arm64
{
    /// <summary>Capstone ARM64 Disassembler.</summary>
    public sealed class CapstoneArm64Disassembler : CapstoneDisassembler<Arm64Instruction, Arm64Register, Arm64InstructionGroup, Arm64InstructionDetail>
    {
        /// <summary>Create a Capstone ARM64 Disassembler.</summary>
        /// <param name="mode">The disassembler's mode.</param>
        public CapstoneArm64Disassembler(DisassembleMode mode)
            : base(DisassembleArchitecture.Arm64, mode)
        {
            return;
        }

        /// <summary>
        ///     Create a Dissembled Instruction.
        /// </summary>
        /// <param name="nativeInstruction">
        ///     A native instruction.
        /// </param>
        /// <returns>
        ///     A dissembled instruction.
        /// </returns>
        protected override Instruction<Arm64Instruction, Arm64Register, Arm64InstructionGroup, Arm64InstructionDetail> CreateInstruction(NativeInstruction nativeInstruction) {
            var @object = nativeInstruction.AsArm64Instruction();

            // x1nix: removed NativeInstruction lookup

            return @object;
        }
    }
}
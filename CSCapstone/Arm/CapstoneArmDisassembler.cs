namespace CSCapstone.Arm
{
    /// <summary>Capstone ARM Disassembler.</summary>
    public sealed class CapstoneArmDisassembler : CapstoneDisassembler<ArmInstruction, ArmRegister, ArmInstructionGroup, ArmInstructionDetail>
    {
        /// <summary>Create a Capstone ARM Disassembler.</summary>
        /// <param name="mode">The disassembler's mode.</param>
        public CapstoneArmDisassembler(DisassembleMode mode)
            : base(DisassembleArchitecture.Arm, mode)
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
        protected override Instruction<ArmInstruction, ArmRegister, ArmInstructionGroup, ArmInstructionDetail> CreateInstruction(NativeInstruction nativeInstruction) {
            var @object = nativeInstruction.AsArmInstruction();

            // x1nix: removed NativeInstruction lookup

            return @object;
        }
    }
}
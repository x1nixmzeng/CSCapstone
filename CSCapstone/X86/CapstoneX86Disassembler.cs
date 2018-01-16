namespace CSCapstone.X86
{
    /// <summary>Capstone X86 Disassembler.</summary>
    public sealed class CapstoneX86Disassembler : CapstoneDisassembler<X86Instruction, X86Register, X86InstructionGroup, X86InstructionDetail>
    {
        /// <summary>Create a Capstone X86 Disassembler.</summary>
        /// <param name="mode">The disassembler's mode.</param>
        public CapstoneX86Disassembler(DisassembleMode mode)
            : base(DisassembleArchitecture.X86, mode)
        {
            return;
        }

        /// <summary>Create a Dissembled Instruction.</summary>
        /// <param name="nativeInstruction">A native instruction.</param>
        /// <returns>A dissembled instruction.</returns>
        protected override Instruction<X86Instruction, X86Register, X86InstructionGroup, X86InstructionDetail> CreateInstruction(NativeInstruction nativeInstruction)
        {
            var @object = nativeInstruction.AsX86Instruction();
            
            // x1nix: removed NativeInstruction lookup

            return @object;
        }
    }
}
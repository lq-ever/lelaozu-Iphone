.subsections_via_symbols
.section __DWARF, __debug_abbrev,regular,debug

	.byte 1,17,1,37,8,3,8,27,8,19,11,17,1,18,1,16,6,0,0,2,46,1,3,8,135,64,8,58,15,59,15,17
	.byte 1,18,1,64,10,0,0,3,5,0,3,8,73,19,2,10,0,0,15,5,0,3,8,73,19,2,6,0,0,4,36,0
	.byte 11,11,62,11,3,8,0,0,5,2,1,3,8,11,15,0,0,17,2,0,3,8,11,15,0,0,6,13,0,3,8,73
	.byte 19,56,10,0,0,7,22,0,3,8,73,19,0,0,8,4,1,3,8,11,15,73,19,0,0,9,40,0,3,8,28,13
	.byte 0,0,10,57,1,3,8,0,0,11,52,0,3,8,73,19,2,10,0,0,12,52,0,3,8,73,19,2,6,0,0,13
	.byte 15,0,73,19,0,0,14,16,0,73,19,0,0,16,28,0,73,19,56,10,0,0,18,46,0,3,8,17,1,18,1,0
	.byte 0,0
.section __DWARF, __debug_info,regular,debug
Ldebug_info_start:

LDIFF_SYM0=Ldebug_info_end - Ldebug_info_begin
	.long LDIFF_SYM0
Ldebug_info_begin:

	.short 2
	.long 0
	.byte 8,1
	.asciz "Mono AOT Compiler 4.2.1 (mono-4.2.0-branch-c6sr0/a7605b3 Tue Dec  1 02:07:11 EST 2015)"
	.asciz "JPush.dll"
	.asciz ""

	.byte 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
LDIFF_SYM1=Ldebug_line_start - Ldebug_line_section_start
	.long LDIFF_SYM1
LDIE_I1:

	.byte 4,1,5
	.asciz "sbyte"
LDIE_U1:

	.byte 4,1,7
	.asciz "byte"
LDIE_I2:

	.byte 4,2,5
	.asciz "short"
LDIE_U2:

	.byte 4,2,7
	.asciz "ushort"
LDIE_I4:

	.byte 4,4,5
	.asciz "int"
LDIE_U4:

	.byte 4,4,7
	.asciz "uint"
LDIE_I8:

	.byte 4,8,5
	.asciz "long"
LDIE_U8:

	.byte 4,8,7
	.asciz "ulong"
LDIE_I:

	.byte 4,8,5
	.asciz "intptr"
LDIE_U:

	.byte 4,8,7
	.asciz "uintptr"
LDIE_R4:

	.byte 4,4,4
	.asciz "float"
LDIE_R8:

	.byte 4,8,4
	.asciz "double"
LDIE_BOOLEAN:

	.byte 4,1,2
	.asciz "boolean"
LDIE_CHAR:

	.byte 4,2,8
	.asciz "char"
LDIE_STRING:

	.byte 4,8,1
	.asciz "string"
LDIE_OBJECT:

	.byte 4,8,1
	.asciz "object"
LDIE_SZARRAY:

	.byte 4,8,1
	.asciz "object"
.section __DWARF, __debug_loc,regular,debug
Ldebug_loc_start:
.section __DWARF, __debug_frame,regular,debug
	.align 3

LDIFF_SYM2=Lcie0_end - Lcie0_start
	.long LDIFF_SYM2
Lcie0_start:

	.long -1
	.byte 3
	.asciz ""

	.byte 1,120,30
	.align 3
Lcie0_end:
.text
	.align 3
jit_code_start:

	.byte 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
.text
	.align 4
	.no_dead_strip ApiDefinition_Messaging__cctor
ApiDefinition_Messaging__cctor:
.word 0xa9bc7bfd
.word 0x910003fd

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #40]
.word 0xf9000bb0
.word 0xf9400a11
.word 0xf9000fb1
.word 0xf9400bb1
.word 0xf9402e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bb1
.word 0xf9404e31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x1, [x16, #48]
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941c430
.word 0xd63f0200
.word 0xf9001ba0
.word 0xf9400bb1
.word 0xf9407e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401ba1

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9000001
.word 0xf9400bb1
.word 0xf940a231
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_e:
.text
	.align 4
	.no_dead_strip JPush_APService__ctor
JPush_APService__ctor:
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #64]
.word 0xf9000fb0
.word 0xf9400a11
.word 0xf90013b1
.word 0xf9400fb1
.word 0xf9403631
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9405631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #72]
.word 0xf9400001
.word 0xaa1a03e0
bl _p_1
.word 0xf9400fb1
.word 0xf9408231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9409231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xaa1a03e0
.word 0xf9400fb1
.word 0xf940aa31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400340
.word 0xf9400c00
.word 0xf9002ba0
.word 0xf9400fb1
.word 0xf940c631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402ba1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941c430
.word 0xd63f0200
.word 0xf90023a0
.word 0xf9400fb1
.word 0xf940ee31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400000
.word 0xf90027a0
.word 0xf9400fb1
.word 0xf9411231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023a0
.word 0xf94027a1
bl _p_2
.word 0x53001c00
.word 0xf9001fa0
.word 0xf9400fb1
.word 0xf9413631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401fa1
.word 0xaa1a03e0
bl _p_3
.word 0xf9400fb1
.word 0xf9415231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf9400fb1
.word 0xf9416631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
bl _p_4
.word 0x53001c00
.word 0xf9001ba0
.word 0xf9400fb1
.word 0xf9418631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401ba0
.word 0x34000760
.word 0xf9400fb1
.word 0xf9419e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf941ae31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xaa1a03e0
.word 0xf9400fb1
.word 0xf941c631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
bl _p_5
.word 0xf90023a0
.word 0xf9400fb1
.word 0xf941e231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf941f231
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_0@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_0@PAGEOFF
ldr x0, [x0]
.word 0xf90027a0
.word 0xf9400fb1
.word 0xf9421231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023a0
.word 0xf94027a1
bl _p_6
.word 0xf9001ba0
.word 0xf9400fb1
.word 0xf9423231
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #80]
.word 0xf9001fa0
.word 0xf9400fb1
.word 0xf9425231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401ba1
.word 0xf9401fa2
.word 0xaa1a03e0
bl _p_7
.word 0xf9400fb1
.word 0xf9427231
.word 0xb4000051
.word 0xd63f0220
.word 0x1400003a
.word 0xf9400fb1
.word 0xf9428631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9429631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xaa1a03e0
.word 0xf9400fb1
.word 0xf942ae31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
bl _p_8
.word 0xf90023a0
.word 0xf9400fb1
.word 0xf942ca31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf942da31
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_0@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_0@PAGEOFF
ldr x0, [x0]
.word 0xf90027a0
.word 0xf9400fb1
.word 0xf942fa31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023a0
.word 0xf94027a1
bl _p_9
.word 0xf9001ba0
.word 0xf9400fb1
.word 0xf9431a31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #80]
.word 0xf9001fa0
.word 0xf9400fb1
.word 0xf9433a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401ba1
.word 0xf9401fa2
.word 0xaa1a03e0
bl _p_7
.word 0xf9400fb1
.word 0xf9435a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9437a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9438a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0

Lme_f:
.text
	.align 4
	.no_dead_strip JPush_APService__ctor_Foundation_NSObjectFlag
JPush_APService__ctor_Foundation_NSObjectFlag:
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xf9000bb9
.word 0xaa0003f9
.word 0xf9000fa1

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #88]
.word 0xf90013b0
.word 0xf9400a11
.word 0xf90017b1
.word 0xf94013b1
.word 0xf9403a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9405a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xf9400fa1
.word 0xaa1903e0
bl _p_1
.word 0xf94013b1
.word 0xf9407a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9408a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xaa1903e0
.word 0xf94013b1
.word 0xf940a231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400320
.word 0xf9400c00
.word 0xf9002fa0
.word 0xf94013b1
.word 0xf940be31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402fa1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941c430
.word 0xd63f0200
.word 0xf90027a0
.word 0xf94013b1
.word 0xf940e631
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400000
.word 0xf9002ba0
.word 0xf94013b1
.word 0xf9410a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94027a0
.word 0xf9402ba1
bl _p_2
.word 0x53001c00
.word 0xf90023a0
.word 0xf94013b1
.word 0xf9412e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023a1
.word 0xaa1903e0
bl _p_3
.word 0xf94013b1
.word 0xf9414a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9415a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bb9
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0

Lme_10:
.text
	.align 4
	.no_dead_strip JPush_APService__ctor_intptr
JPush_APService__ctor_intptr:
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xf9000bb9
.word 0xaa0003f9
.word 0xf9000fa1

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #96]
.word 0xf90013b0
.word 0xf9400a11
.word 0xf90017b1
.word 0xf94013b1
.word 0xf9403a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9405a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xf9400fa1
.word 0xaa1903e0
bl _p_10
.word 0xf94013b1
.word 0xf9407a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9408a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xaa1903e0
.word 0xf94013b1
.word 0xf940a231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400320
.word 0xf9400c00
.word 0xf9002fa0
.word 0xf94013b1
.word 0xf940be31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402fa1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941c430
.word 0xd63f0200
.word 0xf90027a0
.word 0xf94013b1
.word 0xf940e631
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400000
.word 0xf9002ba0
.word 0xf94013b1
.word 0xf9410a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94027a0
.word 0xf9402ba1
bl _p_2
.word 0x53001c00
.word 0xf90023a0
.word 0xf94013b1
.word 0xf9412e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023a1
.word 0xaa1903e0
bl _p_3
.word 0xf94013b1
.word 0xf9414a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9415a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bb9
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0

Lme_11:
.text
	.align 4
	.no_dead_strip JPush_APService_get_ClassHandle
JPush_APService_get_ClassHandle:
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #104]
.word 0xf90013b0
.word 0xf9400a11
.word 0xf90017b1
.word 0xd280001a
.word 0xf94013b1
.word 0xf9403a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9405a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9406a31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xaa0003fa
.word 0xf94013b1
.word 0xf9408e31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xaa1a03e0
.word 0xf94013b1
.word 0xf940a631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_12:
.text
	.align 4
	.no_dead_strip JPush_APService_BeginLogPageView_string_int
JPush_APService_BeginLogPageView_string_int:
.word 0xa9b87bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xaa0003f9
.word 0xf90013a1

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #120]
.word 0xf90017b0
.word 0xf9400a11
.word 0xf9001bb1
.word 0xd2800018
.word 0xf94017b1
.word 0xf9403e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9405e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9406e31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xb50002f9
.word 0xf94017b1
.word 0xf9408631
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2800161
.word 0xd2800161
bl _p_11
.word 0xf90023a0
.word 0xf94017b1
.word 0xf940b231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023a1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf94017b1
.word 0xf940de31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xf94017b1
.word 0xf940f231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
bl _p_13
.word 0xf9003ba0
.word 0xf94017b1
.word 0xf9410e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9403ba0
.word 0xf90037a0
.word 0xaa0003f8
.word 0xf94017b1
.word 0xf9412a31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf90027a0
.word 0xf94017b1
.word 0xf9414e31
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_1@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_1@PAGEOFF
ldr x0, [x0]
.word 0xf9002ba0
.word 0xf94017b1
.word 0xf9416e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94037a0
.word 0xf9002fa0
.word 0xb98023a0
.word 0xf90033a0
.word 0xf94017b1
.word 0xf9418e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94027a0
.word 0xf9402ba1
.word 0xf9402fa2
.word 0xf94033a3
bl _p_14
.word 0xf94017b1
.word 0xf941b231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1803e0
.word 0xf90023a0
.word 0xf94017b1
.word 0xf941ca31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023a0
bl _p_15
.word 0xf94017b1
.word 0xf941e231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf941f231
.word 0xb4000051
.word 0xd63f0220
.word 0xa94167b8
.word 0x910003bf
.word 0xa8c87bfd
.word 0xd65f03c0

Lme_13:
.text
	.align 4
	.no_dead_strip JPush_APService_ClearAllLocalNotifications
JPush_APService_ClearAllLocalNotifications:
.word 0xa9bc7bfd
.word 0x910003fd

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #128]
.word 0xf9000bb0
.word 0xf9400a11
.word 0xf9000fb1
.word 0xf9400bb1
.word 0xf9402e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bb1
.word 0xf9404e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bb1
.word 0xf9405e31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9400bb1
.word 0xf9408231
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_2@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_2@PAGEOFF
ldr x0, [x0]
.word 0xf9001fa0
.word 0xf9400bb1
.word 0xf940a231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401ba0
.word 0xf9401fa1
bl _p_16
.word 0xf9400bb1
.word 0xf940be31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bb1
.word 0xf940ce31
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_14:
.text
	.align 4
	.no_dead_strip JPush_APService_CrashLogON
JPush_APService_CrashLogON:
.word 0xa9bc7bfd
.word 0x910003fd

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #136]
.word 0xf9000bb0
.word 0xf9400a11
.word 0xf9000fb1
.word 0xf9400bb1
.word 0xf9402e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bb1
.word 0xf9404e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bb1
.word 0xf9405e31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9400bb1
.word 0xf9408231
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_3@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_3@PAGEOFF
ldr x0, [x0]
.word 0xf9001fa0
.word 0xf9400bb1
.word 0xf940a231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401ba0
.word 0xf9401fa1
bl _p_16
.word 0xf9400bb1
.word 0xf940be31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bb1
.word 0xf940ce31
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_15:
.text
	.align 4
	.no_dead_strip JPush_APService_DeleteLocalNotification_UIKit_UILocalNotification
JPush_APService_DeleteLocalNotification_UIKit_UILocalNotification:
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #144]
.word 0xf9000fb0
.word 0xf9400a11
.word 0xf90013b1
.word 0xf9400fb1
.word 0xf9403631
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9405631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9406631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xb50002fa
.word 0xf9400fb1
.word 0xf9407e31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28013e1
.word 0xd28013e1
bl _p_11
.word 0xf9001ba0
.word 0xf9400fb1
.word 0xf940aa31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401ba1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf9400fb1
.word 0xf940d631
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9400fb1
.word 0xf940fa31
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_4@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_4@PAGEOFF
ldr x0, [x0]
.word 0xf9001fa0
.word 0xf9400fb1
.word 0xf9411a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf9400fb1
.word 0xf9412e31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf940035e
bl _p_5
.word 0xf90023a0
.word 0xf9400fb1
.word 0xf9414e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401ba0
.word 0xf9401fa1
.word 0xf94023a2
bl _p_17
.word 0xf9400fb1
.word 0xf9416e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9417e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_16:
.text
	.align 4
	.no_dead_strip JPush_APService_DeleteLocalNotificationWithIdentifierKey_string
JPush_APService_DeleteLocalNotificationWithIdentifierKey_string:
.word 0xa9b97bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003fa

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #152]
.word 0xf90013b0
.word 0xf9400a11
.word 0xf90017b1
.word 0xd2800019
.word 0xf94013b1
.word 0xf9403a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9405a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9406a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xb50002fa
.word 0xf94013b1
.word 0xf9408231
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801ea1
.word 0xd2801ea1
bl _p_11
.word 0xf90023a0
.word 0xf94013b1
.word 0xf940ae31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023a1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf94013b1
.word 0xf940da31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf94013b1
.word 0xf940ee31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
bl _p_13
.word 0xf90037a0
.word 0xf94013b1
.word 0xf9410a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94037a0
.word 0xf90033a0
.word 0xaa0003f9
.word 0xf94013b1
.word 0xf9412631
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf90027a0
.word 0xf94013b1
.word 0xf9414a31
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_5@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_5@PAGEOFF
ldr x0, [x0]
.word 0xf9002ba0
.word 0xf94013b1
.word 0xf9416a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94033a0
.word 0xf9002fa0
.word 0xf94013b1
.word 0xf9418231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94027a0
.word 0xf9402ba1
.word 0xf9402fa2
bl _p_17
.word 0xf94013b1
.word 0xf941a231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xf90023a0
.word 0xf94013b1
.word 0xf941ba31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023a0
bl _p_15
.word 0xf94013b1
.word 0xf941d231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf941e231
.word 0xb4000051
.word 0xd63f0220
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0

Lme_17:
.text
	.align 4
	.no_dead_strip JPush_APService_FilterValidTags_Foundation_NSSet
JPush_APService_FilterValidTags_Foundation_NSSet:
.word 0xa9b97bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003fa

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #160]
.word 0xf90013b0
.word 0xf9400a11
.word 0xf90017b1
.word 0xd2800019
.word 0xf94013b1
.word 0xf9403a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9405a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9406a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xb50002fa
.word 0xf94013b1
.word 0xf9408231
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2802d21
.word 0xd2802d21
bl _p_11
.word 0xf90023a0
.word 0xf94013b1
.word 0xf940ae31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023a1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf94013b1
.word 0xf940da31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf9002fa0
.word 0xf94013b1
.word 0xf940fe31
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_6@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_6@PAGEOFF
ldr x0, [x0]
.word 0xf90033a0
.word 0xf94013b1
.word 0xf9411e31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf94013b1
.word 0xf9413231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf940035e
bl _p_5
.word 0xf90037a0
.word 0xf94013b1
.word 0xf9415231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402fa0
.word 0xf94033a1
.word 0xf94037a2
bl _p_18
.word 0xf9002ba0
.word 0xf94013b1
.word 0xf9417631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402ba0

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x15, [x16, #168]
bl _p_19
.word 0xf90027a0
.word 0xf94013b1
.word 0xf9419e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94027a0
.word 0xf90023a0
.word 0xaa0003f9
.word 0xf94013b1
.word 0xf941ba31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023a0
.word 0xaa0003e1
.word 0xf94013b1
.word 0xf941d231
.word 0xb4000051
.word 0xd63f0220
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0

Lme_18:
.text
	.align 4
	.no_dead_strip JPush_APService_FindLocalNotificationWithIdentifier_string
JPush_APService_FindLocalNotificationWithIdentifier_string:
.word 0xa9b77bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xa9026bb9
.word 0xaa0003fa

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #176]
.word 0xf9001bb0
.word 0xf9400a11
.word 0xf9001fb1
.word 0xd2800019
.word 0xd2800018
.word 0xd2800017
.word 0xf9401bb1
.word 0xf9404631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf9406631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf9407631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xb50002fa
.word 0xf9401bb1
.word 0xf9408e31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801ea1
.word 0xd2801ea1
bl _p_11
.word 0xf9002ba0
.word 0xf9401bb1
.word 0xf940ba31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402ba1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf9401bb1
.word 0xf940e631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf9401bb1
.word 0xf940fa31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
bl _p_13
.word 0xf90047a0
.word 0xf9401bb1
.word 0xf9411631
.word 0xb4000051
.word 0xd63f0220
.word 0xf94047a0
.word 0xf90043a0
.word 0xaa0003f9
.word 0xf9401bb1
.word 0xf9413231
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf90037a0
.word 0xf9401bb1
.word 0xf9415631
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_7@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_7@PAGEOFF
ldr x0, [x0]
.word 0xf9003ba0
.word 0xf9401bb1
.word 0xf9417631
.word 0xb4000051
.word 0xd63f0220
.word 0xf94043a0
.word 0xf9003fa0
.word 0xf9401bb1
.word 0xf9418e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94037a0
.word 0xf9403ba1
.word 0xf9403fa2
bl _p_18
.word 0xf90033a0
.word 0xf9401bb1
.word 0xf941b231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94033a0

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x15, [x16, #184]
bl _p_20
.word 0xf9002fa0
.word 0xf9401bb1
.word 0xf941da31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402fa0
.word 0xaa0003f8
.word 0xf9401bb1
.word 0xf941f231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xf9002ba0
.word 0xf9401bb1
.word 0xf9420a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402ba0
bl _p_15
.word 0xf9401bb1
.word 0xf9422231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1803e0
.word 0xaa0003f7
.word 0xf9401bb1
.word 0xf9423a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1703e0
.word 0xaa1703e0
.word 0xf9401bb1
.word 0xf9425231
.word 0xb4000051
.word 0xd63f0220
.word 0xa94163b7
.word 0xa9426bb9
.word 0x910003bf
.word 0xa8c97bfd
.word 0xd65f03c0

Lme_19:
.text
	.align 4
	.no_dead_strip JPush_APService_HandleRemoteNotification_Foundation_NSDictionary
JPush_APService_HandleRemoteNotification_Foundation_NSDictionary:
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #192]
.word 0xf9000fb0
.word 0xf9400a11
.word 0xf90013b1
.word 0xf9400fb1
.word 0xf9403631
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9405631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9406631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xb50002fa
.word 0xf9400fb1
.word 0xf9407e31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2803be1
.word 0xd2803be1
bl _p_11
.word 0xf9001ba0
.word 0xf9400fb1
.word 0xf940aa31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401ba1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf9400fb1
.word 0xf940d631
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9400fb1
.word 0xf940fa31
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_8@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_8@PAGEOFF
ldr x0, [x0]
.word 0xf9001fa0
.word 0xf9400fb1
.word 0xf9411a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf9400fb1
.word 0xf9412e31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf940035e
bl _p_5
.word 0xf90023a0
.word 0xf9400fb1
.word 0xf9414e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401ba0
.word 0xf9401fa1
.word 0xf94023a2
bl _p_17
.word 0xf9400fb1
.word 0xf9416e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9417e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_1a:
.text
	.align 4
	.no_dead_strip JPush_APService_RegisterDeviceToken_Foundation_NSData
JPush_APService_RegisterDeviceToken_Foundation_NSData:
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #200]
.word 0xf9000fb0
.word 0xf9400a11
.word 0xf90013b1
.word 0xf9400fb1
.word 0xf9403631
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9405631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9406631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xb50002fa
.word 0xf9400fb1
.word 0xf9407e31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2804521
.word 0xd2804521
bl _p_11
.word 0xf9001ba0
.word 0xf9400fb1
.word 0xf940aa31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401ba1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf9400fb1
.word 0xf940d631
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9400fb1
.word 0xf940fa31
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_9@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_9@PAGEOFF
ldr x0, [x0]
.word 0xf9001fa0
.word 0xf9400fb1
.word 0xf9411a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf9400fb1
.word 0xf9412e31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf940035e
bl _p_5
.word 0xf90023a0
.word 0xf9400fb1
.word 0xf9414e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401ba0
.word 0xf9401fa1
.word 0xf94023a2
bl _p_17
.word 0xf9400fb1
.word 0xf9416e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9417e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_1b:
.text
	.align 4
	.no_dead_strip JPush_APService_RegisterForRemoteNotificationTypes_System_nuint_Foundation_NSSet
JPush_APService_RegisterForRemoteNotificationTypes_System_nuint_Foundation_NSSet:
.word 0xa9b97bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xa90263b7
.word 0xf9001bba
.word 0xf9001fa0
.word 0xaa0103fa

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #208]
.word 0xf90023b0
.word 0xf9400a11
.word 0xf90027b1
.word 0xf94023b1
.word 0xf9404231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94027b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023b1
.word 0xf9406231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023b1
.word 0xf9407231
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf90037a0
.word 0xf94023b1
.word 0xf9409631
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_10@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_10@PAGEOFF
ldr x0, [x0]
.word 0xf90033a0
.word 0xf94023b1
.word 0xf940b631
.word 0xb4000051
.word 0xd63f0220
.word 0xf94033a1
.word 0xf94037a2
.word 0xf9401fa0
.word 0xaa1a03e3
.word 0xaa0203f8
.word 0xaa0103f7
.word 0xaa0003f6
.word 0xb500015a
.word 0xaa1803e0
.word 0xaa1703e0
.word 0xaa1603e0

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #216]
.word 0xf9400000
.word 0xaa0003f5
.word 0x1400000d
.word 0xaa1803e0
.word 0xaa1703e0
.word 0xaa1603e0
.word 0xaa1a03e0
.word 0xf94023b1
.word 0xf9411a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf940035e
bl _p_5
.word 0xaa0003f5
.word 0xaa1803e0
.word 0xaa1703e0
.word 0xaa1603e0
.word 0xaa1503e0
.word 0xf94023b1
.word 0xf9414a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1803e0
.word 0xaa1703e1
.word 0xaa1603e2
.word 0xaa1503e3
bl _p_21
.word 0xf94023b1
.word 0xf9416e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023b1
.word 0xf9417e31
.word 0xb4000051
.word 0xd63f0220
.word 0xa9415bb5
.word 0xa94263b7
.word 0xf9401bba
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0

Lme_1c:
.text
	.align 4
	.no_dead_strip JPush_APService_ResetBadge
JPush_APService_ResetBadge:
.word 0xa9bc7bfd
.word 0x910003fd

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #224]
.word 0xf9000bb0
.word 0xf9400a11
.word 0xf9000fb1
.word 0xf9400bb1
.word 0xf9402e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bb1
.word 0xf9404e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bb1
.word 0xf9405e31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9400bb1
.word 0xf9408231
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_11@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_11@PAGEOFF
ldr x0, [x0]
.word 0xf9001fa0
.word 0xf9400bb1
.word 0xf940a231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401ba0
.word 0xf9401fa1
bl _p_16
.word 0xf9400bb1
.word 0xf940be31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bb1
.word 0xf940ce31
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_1d:
.text
	.align 4
	.no_dead_strip JPush_APService_SetAlias_string_ObjCRuntime_Selector_Foundation_NSObject
JPush_APService_SetAlias_string_ObjCRuntime_Selector_Foundation_NSObject:
.word 0xa9b57bfd
.word 0x910003fd
.word 0xa90153b3
.word 0xa9025bb5
.word 0xf9001bb7
.word 0xa903ebb9
.word 0xf90027a0
.word 0xaa0103f9
.word 0xf9002ba2

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #232]
.word 0xf9002fb0
.word 0xf9400a11
.word 0xf90033b1
.word 0xd2800017
.word 0xf9402fb1
.word 0xf9404e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94033b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402fb1
.word 0xf9406e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402fb1
.word 0xf9407e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94027a0
.word 0xf90053a0
.word 0xf9402fb1
.word 0xf9409631
.word 0xb4000051
.word 0xd63f0220
.word 0xf94053a0
bl _p_13
.word 0xf9004fa0
.word 0xf9402fb1
.word 0xf940b231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9404fa0
.word 0xf9004ba0
.word 0xaa0003f7
.word 0xf9402fb1
.word 0xf940ce31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf90047a0
.word 0xf9402fb1
.word 0xf940f231
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_12@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_12@PAGEOFF
ldr x0, [x0]
.word 0xf90043a0
.word 0xf9402fb1
.word 0xf9411231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9404ba0
.word 0xf9003fa0
.word 0xaa1903e0
.word 0xd2800000
.word 0xf9402fb1
.word 0xf9413231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xd2800001
bl _p_22
.word 0x53001c00
.word 0xf9003ba0
.word 0xf9402fb1
.word 0xf9415631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9403ba0
.word 0xf9403fa1
.word 0xf94043a2
.word 0xf94047a3
.word 0xaa0303f6
.word 0xaa0203f5
.word 0xaa0103f4
.word 0x34000140
.word 0xaa1603e0
.word 0xaa1503e0
.word 0xaa1403e0

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #216]
.word 0xf9400000
.word 0xaa0003f3
.word 0x14000013
.word 0xaa1603e0
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1903e0
.word 0xf9402fb1
.word 0xf941ba31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xf940033e
bl _p_23
.word 0xf9003ba0
.word 0xf9402fb1
.word 0xf941da31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9403ba0
.word 0xaa0003f3
.word 0xaa1603e0
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1303e0
.word 0xf9402ba0
.word 0xb5000160
.word 0xaa1603e0
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1303e0

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #216]
.word 0xf9400000
.word 0xaa0003fa
.word 0x14000010
.word 0xaa1603e0
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1303e0
.word 0xf9402ba0
.word 0xf9003ba0
.word 0xf9402fb1
.word 0xf9424a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9403ba1
.word 0xaa0103e0
.word 0xf940003e
bl _p_5
.word 0xaa0003fa
.word 0xaa1603e0
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1303e0
.word 0xaa1a03e0
.word 0xf9402fb1
.word 0xf9428231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1603e0
.word 0xaa1503e1
.word 0xaa1403e2
.word 0xaa1303e3
.word 0xaa1a03e4
bl _p_24
.word 0xf9402fb1
.word 0xf942aa31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1703e0
.word 0xf9402fb1
.word 0xf942be31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1703e0
bl _p_15
.word 0xf9402fb1
.word 0xf942d631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402fb1
.word 0xf942e631
.word 0xb4000051
.word 0xd63f0220
.word 0xa94153b3
.word 0xa9425bb5
.word 0xf9401bb7
.word 0xa943ebb9
.word 0x910003bf
.word 0xa8cb7bfd
.word 0xd65f03c0

Lme_1e:
.text
	.align 4
	.no_dead_strip JPush_APService_SetBadge_System_nint
JPush_APService_SetBadge_System_nint:
.word 0xa9b97bfd
.word 0x910003fd
.word 0xf9000bb9
.word 0xf9000fa0

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #240]
.word 0xf90013b0
.word 0xf9400a11
.word 0xf90017b1
.word 0xd2800019
.word 0xf94013b1
.word 0xf9403a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9405a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9406a31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf9002ba0
.word 0xf94013b1
.word 0xf9408e31
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_13@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_13@PAGEOFF
ldr x0, [x0]
.word 0xf9002fa0
.word 0xf94013b1
.word 0xf940ae31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fa0
.word 0xf90033a0
.word 0xf94013b1
.word 0xf940c631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402ba0
.word 0xf9402fa1
.word 0xf94033a2
bl _p_25
.word 0x53001c00
.word 0xf90027a0
.word 0xf94013b1
.word 0xf940ee31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94027a0
.word 0xf90023a0
.word 0xaa0003f9
.word 0xf94013b1
.word 0xf9410a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023a0
.word 0xaa0003e1
.word 0xf94013b1
.word 0xf9412231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bb9
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0

Lme_1f:
.text
	.align 4
	.no_dead_strip JPush_APService_SetDebugMode
JPush_APService_SetDebugMode:
.word 0xa9bc7bfd
.word 0x910003fd

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #248]
.word 0xf9000bb0
.word 0xf9400a11
.word 0xf9000fb1
.word 0xf9400bb1
.word 0xf9402e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bb1
.word 0xf9404e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bb1
.word 0xf9405e31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9400bb1
.word 0xf9408231
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_14@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_14@PAGEOFF
ldr x0, [x0]
.word 0xf9001fa0
.word 0xf9400bb1
.word 0xf940a231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401ba0
.word 0xf9401fa1
bl _p_16
.word 0xf9400bb1
.word 0xf940be31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bb1
.word 0xf940ce31
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_20:
.text
	.align 4
	.no_dead_strip JPush_APService_SetLatitude_double_double
JPush_APService_SetLatitude_double_double:
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xfd000ba0
.word 0xfd000fa1

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #256]
.word 0xf90013b0
.word 0xf9400a11
.word 0xf90017b1
.word 0xf94013b1
.word 0xf9403631
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9405631
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9406631
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf90023a0
.word 0xf94013b1
.word 0xf9408a31
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_15@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_15@PAGEOFF
ldr x0, [x0]
.word 0xf90027a0
.word 0xf94013b1
.word 0xf940aa31
.word 0xb4000051
.word 0xd63f0220
.word 0xfd400ba0
.word 0xfd002ba0
.word 0xfd400fa0
.word 0xfd002fa0
.word 0xf94013b1
.word 0xf940ca31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023a0
.word 0xf94027a1
.word 0xfd402ba0
.word 0xfd402fa1
bl _p_26
.word 0xf94013b1
.word 0xf940ee31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf940fe31
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0

Lme_21:
.text
	.align 4
	.no_dead_strip JPush_APService_SetLocalNotification_Foundation_NSDate_string_int_string_string_Foundation_NSDictionary_string
JPush_APService_SetLocalNotification_Foundation_NSDate_string_int_string_string_Foundation_NSDictionary_string:
.word 0xa9ad7bfd
.word 0x910003fd
.word 0xd2800210
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0xa90153b3
.word 0xf90013b5
.word 0xa902e3b7
.word 0xf9001fb9
.word 0xaa0003f4
.word 0xaa0103f5
.word 0xf90023a2
.word 0xaa0303f7
.word 0xaa0403f8
.word 0xaa0503f9
.word 0xf90027a6

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #264]
.word 0xf9002bb0
.word 0xf9400a11
.word 0xf9002fb1
.word 0xd2800013
.word 0xf90037bf
.word 0xf9003bbf
.word 0xf9003fbf
.word 0xf90043bf
.word 0xf90047bf
.word 0xf9402bb1
.word 0xf9408231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402bb1
.word 0xf940a231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402bb1
.word 0xf940b231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1403e0
.word 0xb50002f4
.word 0xf9402bb1
.word 0xf940ca31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2806fe1
.word 0xd2806fe1
bl _p_11
.word 0xf9004ba0
.word 0xf9402bb1
.word 0xf940f631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9404ba1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf9402bb1
.word 0xf9412231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1503e0
.word 0xb50002f5
.word 0xf9402bb1
.word 0xf9413a31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2807221
.word 0xd2807221
bl _p_11
.word 0xf9004ba0
.word 0xf9402bb1
.word 0xf9416631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9404ba1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf9402bb1
.word 0xf9419231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1703e0
.word 0xb50002f7
.word 0xf9402bb1
.word 0xf941aa31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28074a1
.word 0xd28074a1
bl _p_11
.word 0xf9004ba0
.word 0xf9402bb1
.word 0xf941d631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9404ba1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf9402bb1
.word 0xf9420231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1803e0
.word 0xb50002f8
.word 0xf9402bb1
.word 0xf9421a31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801ea1
.word 0xd2801ea1
bl _p_11
.word 0xf9004ba0
.word 0xf9402bb1
.word 0xf9424631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9404ba1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf9402bb1
.word 0xf9427231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xb50002f9
.word 0xf9402bb1
.word 0xf9428a31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28078a1
.word 0xd28078a1
bl _p_11
.word 0xf9004ba0
.word 0xf9402bb1
.word 0xf942b631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9404ba1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf9402bb1
.word 0xf942e231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1503e0
.word 0xf9402bb1
.word 0xf942f631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1503e0
bl _p_13
.word 0xf90097a0
.word 0xf9402bb1
.word 0xf9431231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94097a0
.word 0xaa0003f3
.word 0xf9402bb1
.word 0xf9432a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1703e0
.word 0xf9402bb1
.word 0xf9433e31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1703e0
bl _p_13
.word 0xf90093a0
.word 0xf9402bb1
.word 0xf9435a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94093a0
.word 0xf90037a0
.word 0xf9402bb1
.word 0xf9437231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1803e0
.word 0xf9402bb1
.word 0xf9438631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1803e0
bl _p_13
.word 0xf9008fa0
.word 0xf9402bb1
.word 0xf943a231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9408fa0
.word 0xf9003ba0
.word 0xf9402bb1
.word 0xf943ba31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94027a0
.word 0xf9008ba0
.word 0xf9402bb1
.word 0xf943d231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9408ba0
bl _p_13
.word 0xf90087a0
.word 0xf9402bb1
.word 0xf943ee31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94087a0
.word 0xf9003fa0
.word 0xf9402bb1
.word 0xf9440631
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf90063a0
.word 0xf9402bb1
.word 0xf9442a31
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_16@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_16@PAGEOFF
ldr x0, [x0]
.word 0xf90067a0
.word 0xf9402bb1
.word 0xf9444a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1403e0
.word 0xf9402bb1
.word 0xf9445e31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1403e0
.word 0xf940029e
bl _p_5
.word 0xf9006ba0
.word 0xf9402bb1
.word 0xf9447e31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1303e0
.word 0xf9006fa0
.word 0xb98043a0
.word 0xf90073a0
.word 0xf94037a0
.word 0xf90077a0
.word 0xf9403ba0
.word 0xf9007ba0
.word 0xaa1903e0
.word 0xf9402bb1
.word 0xf944b231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xf940033e
bl _p_5
.word 0xf9007fa0
.word 0xf9402bb1
.word 0xf944d231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9403fa0
.word 0xf90083a0
.word 0xf9402bb1
.word 0xf944ea31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94063a0
.word 0xf94067a1
.word 0xf9406ba2
.word 0xf9406fa3
.word 0xf94073a4
.word 0xf94077a5
.word 0xf9407ba6
.word 0xf9407fa7
.word 0xf94083a9
.word 0xf90003e9
bl _p_27
.word 0xf9005fa0
.word 0xf9402bb1
.word 0xf9452a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9405fa0

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x15, [x16, #272]
bl _p_28
.word 0xf9005ba0
.word 0xf9402bb1
.word 0xf9455231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9405ba0
.word 0xf90043a0
.word 0xf9402bb1
.word 0xf9456a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1303e0
.word 0xf90057a0
.word 0xf9402bb1
.word 0xf9458231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94057a0
bl _p_15
.word 0xf9402bb1
.word 0xf9459a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94037a0
.word 0xf90053a0
.word 0xf9402bb1
.word 0xf945b231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94053a0
bl _p_15
.word 0xf9402bb1
.word 0xf945ca31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9403ba0
.word 0xf9004fa0
.word 0xf9402bb1
.word 0xf945e231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9404fa0
bl _p_15
.word 0xf9402bb1
.word 0xf945fa31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9403fa0
.word 0xf9004ba0
.word 0xf9402bb1
.word 0xf9461231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9404ba0
bl _p_15
.word 0xf9402bb1
.word 0xf9462a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94043a0
.word 0xf90047a0
.word 0xf9402bb1
.word 0xf9464231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94047a0
.word 0xf9402bb1
.word 0xf9465631
.word 0xb4000051
.word 0xd63f0220
.word 0xa94153b3
.word 0xf94013b5
.word 0xa942e3b7
.word 0xf9401fb9
.word 0x910003bf
.word 0xa8d37bfd
.word 0xd65f03c0

Lme_22:
.text
	.align 4
	.no_dead_strip JPush_APService_SetLocalNotification_Foundation_NSDate_string_int_string_string_Foundation_NSDictionary_string_CoreLocation_CLRegion_bool_string
JPush_APService_SetLocalNotification_Foundation_NSDate_string_int_string_string_Foundation_NSDictionary_string_CoreLocation_CLRegion_bool_string:
.word 0xa9a57bfd
.word 0x910003fd
.word 0xd2800410
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0xa90153b3
.word 0xa9025bb5
.word 0xa90363b7
.word 0xa9046bb9
.word 0xf9002bbc
.word 0x9106c3bc
.word 0xf9002fa0
.word 0xaa0103f9
.word 0xf90033a2
.word 0xf90037a3
.word 0xf9003ba4
.word 0xf9003fa5
.word 0xf90043a6
.word 0xf90047a7

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #280]
.word 0xf9004bb0
.word 0xf9400a11
.word 0xf9004fb1
.word 0xd2800018
.word 0xd2800016
.word 0xd2800013
.word 0xd280001a
.word 0xd2800017
.word 0xd2800015
.word 0xd2800014
.word 0xf9404bb1
.word 0xf9409231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9404fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9404bb1
.word 0xf940b231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9404bb1
.word 0xf940c231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402fa0
.word 0xb50002e0
.word 0xf9404bb1
.word 0xf940da31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2806fe1
.word 0xd2806fe1
bl _p_11
.word 0xf9005ba0
.word 0xf9404bb1
.word 0xf9410631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9405ba1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf9404bb1
.word 0xf9413231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xb50002f9
.word 0xf9404bb1
.word 0xf9414a31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2807221
.word 0xd2807221
bl _p_11
.word 0xf9005ba0
.word 0xf9404bb1
.word 0xf9417631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9405ba1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf9404bb1
.word 0xf941a231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94037a0
.word 0xb50002e0
.word 0xf9404bb1
.word 0xf941ba31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28074a1
.word 0xd28074a1
bl _p_11
.word 0xf9005ba0
.word 0xf9404bb1
.word 0xf941e631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9405ba1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf9404bb1
.word 0xf9421231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9403ba0
.word 0xb50002e0
.word 0xf9404bb1
.word 0xf9422a31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801ea1
.word 0xd2801ea1
bl _p_11
.word 0xf9005ba0
.word 0xf9404bb1
.word 0xf9425631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9405ba1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf9404bb1
.word 0xf9428231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9403fa0
.word 0xb50002e0
.word 0xf9404bb1
.word 0xf9429a31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28078a1
.word 0xd28078a1
bl _p_11
.word 0xf9005ba0
.word 0xf9404bb1
.word 0xf942c631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9405ba1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf9404bb1
.word 0xf942f231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94043a0
.word 0xb50002e0
.word 0xf9404bb1
.word 0xf9430a31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2808fc1
.word 0xd2808fc1
bl _p_11
.word 0xf9005ba0
.word 0xf9404bb1
.word 0xf9433631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9405ba1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf9404bb1
.word 0xf9436231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94047a0
.word 0xb50002e0
.word 0xf9404bb1
.word 0xf9437a31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2809241
.word 0xd2809241
bl _p_11
.word 0xf9005ba0
.word 0xf9404bb1
.word 0xf943a631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9405ba1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf9404bb1
.word 0xf943d231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400780
.word 0xb50002e0
.word 0xf9404bb1
.word 0xf943ea31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2809401
.word 0xd2809401
bl _p_11
.word 0xf9005ba0
.word 0xf9404bb1
.word 0xf9441631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9405ba1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf9404bb1
.word 0xf9444231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xf9404bb1
.word 0xf9445631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
bl _p_13
.word 0xf900d3a0
.word 0xf9404bb1
.word 0xf9447231
.word 0xb4000051
.word 0xd63f0220
.word 0xf940d3a0
.word 0xaa0003f8
.word 0xf9404bb1
.word 0xf9448a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94037a0
.word 0xf900cfa0
.word 0xf9404bb1
.word 0xf944a231
.word 0xb4000051
.word 0xd63f0220
.word 0xf940cfa0
bl _p_13
.word 0xf900cba0
.word 0xf9404bb1
.word 0xf944be31
.word 0xb4000051
.word 0xd63f0220
.word 0xf940cba0
.word 0xaa0003f6
.word 0xf9404bb1
.word 0xf944d631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9403ba0
.word 0xf900c7a0
.word 0xf9404bb1
.word 0xf944ee31
.word 0xb4000051
.word 0xd63f0220
.word 0xf940c7a0
bl _p_13
.word 0xf900c3a0
.word 0xf9404bb1
.word 0xf9450a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf940c3a0
.word 0xaa0003f3
.word 0xf9404bb1
.word 0xf9452231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94043a0
.word 0xf900bfa0
.word 0xf9404bb1
.word 0xf9453a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf940bfa0
bl _p_13
.word 0xf900bba0
.word 0xf9404bb1
.word 0xf9455631
.word 0xb4000051
.word 0xd63f0220
.word 0xf940bba0
.word 0xaa0003fa
.word 0xf9404bb1
.word 0xf9456e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400780
.word 0xf900b7a0
.word 0xf9404bb1
.word 0xf9458631
.word 0xb4000051
.word 0xd63f0220
.word 0xf940b7a0
bl _p_13
.word 0xf900b3a0
.word 0xf9404bb1
.word 0xf945a231
.word 0xb4000051
.word 0xd63f0220
.word 0xf940b3a0
.word 0xaa0003f7
.word 0xf9404bb1
.word 0xf945ba31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf90077a0
.word 0xf9404bb1
.word 0xf945de31
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_17@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_17@PAGEOFF
ldr x0, [x0]
.word 0xf9007ba0
.word 0xf9404bb1
.word 0xf945fe31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402fa0
.word 0xf900afa0
.word 0xf9404bb1
.word 0xf9461631
.word 0xb4000051
.word 0xd63f0220
.word 0xf940afa1
.word 0xaa0103e0
.word 0xf940003e
bl _p_5
.word 0xf9007fa0
.word 0xf9404bb1
.word 0xf9463a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1803e0
.word 0xf90083a0
.word 0xb98063a0
.word 0xf90087a0
.word 0xaa1603e0
.word 0xf9008ba0
.word 0xaa1303e0
.word 0xf9008fa0
.word 0xf9403fa0
.word 0xf900aba0
.word 0xf9404bb1
.word 0xf9467231
.word 0xb4000051
.word 0xd63f0220
.word 0xf940aba1
.word 0xaa0103e0
.word 0xf940003e
bl _p_5
.word 0xf90093a0
.word 0xf9404bb1
.word 0xf9469631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf900a3a0
.word 0xf94047a0
.word 0xf900a7a0
.word 0xf9404bb1
.word 0xf946b631
.word 0xb4000051
.word 0xd63f0220
.word 0xf940a7a1
.word 0xaa0103e0
.word 0xf940003e
bl _p_5
.word 0xf9009fa0
.word 0xf9404bb1
.word 0xf946da31
.word 0xb4000051
.word 0xd63f0220
.word 0x39400380
.word 0xf9009ba0
.word 0xaa1703e0
.word 0xf90097a0
.word 0xf9404bb1
.word 0xf946fa31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94077a0
.word 0xf9407ba1
.word 0xf9407fa2
.word 0xf94083a3
.word 0xf94087a4
.word 0xf9408ba5
.word 0xf9408fa6
.word 0xf94093a7
.word 0xf94097a9
.word 0xf9409baa
.word 0xf9409fab
.word 0xf940a3ac
.word 0xf90003ec
.word 0xf90007eb
.word 0x390043ea
.word 0xf9000fe9
bl _p_29
.word 0xf90073a0
.word 0xf9404bb1
.word 0xf9475231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94073a0

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x15, [x16, #272]
bl _p_28
.word 0xf9006fa0
.word 0xf9404bb1
.word 0xf9477a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9406fa0
.word 0xaa0003f5
.word 0xf9404bb1
.word 0xf9479231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1803e0
.word 0xf9006ba0
.word 0xf9404bb1
.word 0xf947aa31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9406ba0
bl _p_15
.word 0xf9404bb1
.word 0xf947c231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1603e0
.word 0xf90067a0
.word 0xf9404bb1
.word 0xf947da31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94067a0
bl _p_15
.word 0xf9404bb1
.word 0xf947f231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1303e0
.word 0xf90063a0
.word 0xf9404bb1
.word 0xf9480a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94063a0
bl _p_15
.word 0xf9404bb1
.word 0xf9482231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf9005fa0
.word 0xf9404bb1
.word 0xf9483a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9405fa0
bl _p_15
.word 0xf9404bb1
.word 0xf9485231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1703e0
.word 0xf9005ba0
.word 0xf9404bb1
.word 0xf9486a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9405ba0
bl _p_15
.word 0xf9404bb1
.word 0xf9488231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1503e0
.word 0xaa0003f4
.word 0xf9404bb1
.word 0xf9489a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1403e0
.word 0xaa1403e0
.word 0xf9404bb1
.word 0xf948b231
.word 0xb4000051
.word 0xd63f0220
.word 0xa94153b3
.word 0xa9425bb5
.word 0xa94363b7
.word 0xa9446bb9
.word 0xf9402bbc
.word 0x910003bf
.word 0xa8db7bfd
.word 0xd65f03c0

Lme_23:
.text
	.align 4
	.no_dead_strip JPush_APService_SetLocation_CoreLocation_CLLocation
JPush_APService_SetLocation_CoreLocation_CLLocation:
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #288]
.word 0xf9000fb0
.word 0xf9400a11
.word 0xf90013b1
.word 0xf9400fb1
.word 0xf9403631
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9405631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9406631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xb50002fa
.word 0xf9400fb1
.word 0xf9407e31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd280b3e1
.word 0xd280b3e1
bl _p_11
.word 0xf9001ba0
.word 0xf9400fb1
.word 0xf940aa31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401ba1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf9400fb1
.word 0xf940d631
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9400fb1
.word 0xf940fa31
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_18@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_18@PAGEOFF
ldr x0, [x0]
.word 0xf9001fa0
.word 0xf9400fb1
.word 0xf9411a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf9400fb1
.word 0xf9412e31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf940035e
bl _p_5
.word 0xf90023a0
.word 0xf9400fb1
.word 0xf9414e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401ba0
.word 0xf9401fa1
.word 0xf94023a2
bl _p_17
.word 0xf9400fb1
.word 0xf9416e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9417e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_24:
.text
	.align 4
	.no_dead_strip JPush_APService_SetLogOFF
JPush_APService_SetLogOFF:
.word 0xa9bc7bfd
.word 0x910003fd

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #296]
.word 0xf9000bb0
.word 0xf9400a11
.word 0xf9000fb1
.word 0xf9400bb1
.word 0xf9402e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bb1
.word 0xf9404e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bb1
.word 0xf9405e31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9400bb1
.word 0xf9408231
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_19@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_19@PAGEOFF
ldr x0, [x0]
.word 0xf9001fa0
.word 0xf9400bb1
.word 0xf940a231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401ba0
.word 0xf9401fa1
bl _p_16
.word 0xf9400bb1
.word 0xf940be31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bb1
.word 0xf940ce31
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_25:
.text
	.align 4
	.no_dead_strip JPush_APService_SetTagsWithObject_Foundation_NSSet_string_ObjCRuntime_Selector_Foundation_NSObject
JPush_APService_SetTagsWithObject_Foundation_NSSet_string_ObjCRuntime_Selector_Foundation_NSObject:
.word 0xa9b67bfd
.word 0x910003fd
.word 0xa90153b3
.word 0xa9025bb5
.word 0xf9001bb7
.word 0xa903ebb9
.word 0xaa0003f7
.word 0xf90027a1
.word 0xf9002ba2
.word 0xf9002fa3

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #304]
.word 0xf90033b0
.word 0xf9400a11
.word 0xf90037b1
.word 0xd2800016
.word 0xf94033b1
.word 0xf9405231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94037b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94033b1
.word 0xf9407231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94033b1
.word 0xf9408231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94027a0
.word 0xf9004fa0
.word 0xf94033b1
.word 0xf9409a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9404fa0
bl _p_13
.word 0xf9004ba0
.word 0xf94033b1
.word 0xf940b631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9404ba0
.word 0xaa0003f6
.word 0xf94033b1
.word 0xf940ce31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf90047a0
.word 0xf94033b1
.word 0xf940f231
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_20@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_20@PAGEOFF
ldr x0, [x0]
.word 0xf90043a0
.word 0xf94033b1
.word 0xf9411231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94043a0
.word 0xf94047a1
.word 0xaa1703e2
.word 0xaa0103f5
.word 0xaa0003f4
.word 0xb5000137
.word 0xaa1503e0
.word 0xaa1403e0

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #216]
.word 0xf9400000
.word 0xaa0003f3
.word 0x14000012
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1703e0
.word 0xf94033b1
.word 0xf9416631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1703e0
.word 0xf94002fe
bl _p_5
.word 0xf90043a0
.word 0xf94033b1
.word 0xf9418631
.word 0xb4000051
.word 0xd63f0220
.word 0xf94043a0
.word 0xaa0003f3
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1303e0
.word 0xaa1603e0
.word 0xf9402ba0
.word 0xf90047a0
.word 0xd2800000
.word 0xf94033b1
.word 0xf941ba31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94047a0
.word 0xd2800001
bl _p_22
.word 0x53001c00
.word 0xf90043a0
.word 0xf94033b1
.word 0xf941de31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94043a0
.word 0xaa1603fa
.word 0x34000160
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1303e0
.word 0xaa1a03e0

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #216]
.word 0xf9400000
.word 0xaa0003f9
.word 0x14000016
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1303e0
.word 0xaa1a03e0
.word 0xf9402ba0
.word 0xf90047a0
.word 0xf94033b1
.word 0xf9423a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94047a1
.word 0xaa0103e0
.word 0xf940003e
bl _p_23
.word 0xf90043a0
.word 0xf94033b1
.word 0xf9425e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94043a0
.word 0xaa0003f9
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1303e0
.word 0xaa1a03e0
.word 0xaa1903e0
.word 0xf9402fa0
.word 0xb5000180
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1303e0
.word 0xaa1a03e0
.word 0xaa1903e0

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #216]
.word 0xf9400000
.word 0xf9003fa0
.word 0x14000011
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1303e0
.word 0xaa1a03e0
.word 0xaa1903e0
.word 0xf9402fa0
.word 0xf90043a0
.word 0xf94033b1
.word 0xf942da31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94043a1
.word 0xaa0103e0
.word 0xf940003e
bl _p_5
.word 0xf9003fa0
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1303e0
.word 0xaa1a03e0
.word 0xaa1903e0
.word 0xf9403fa0
.word 0xf90043a0
.word 0xf94033b1
.word 0xf9431a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94043a5
.word 0xaa1503e0
.word 0xaa1403e1
.word 0xaa1303e2
.word 0xaa1a03e3
.word 0xaa1903e4
bl _p_30
.word 0xf94033b1
.word 0xf9434631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1603e0
.word 0xf94033b1
.word 0xf9435a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1603e0
bl _p_15
.word 0xf94033b1
.word 0xf9437231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94033b1
.word 0xf9438231
.word 0xb4000051
.word 0xd63f0220
.word 0xa94153b3
.word 0xa9425bb5
.word 0xf9401bb7
.word 0xa943ebb9
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0

Lme_26:
.text
	.align 4
	.no_dead_strip JPush_APService_SetTagsWithTarger_Foundation_NSSet_string_ObjCRuntime_Selector_Foundation_NSObject
JPush_APService_SetTagsWithTarger_Foundation_NSSet_string_ObjCRuntime_Selector_Foundation_NSObject:
.word 0xa9b67bfd
.word 0x910003fd
.word 0xa90153b3
.word 0xa9025bb5
.word 0xf9001bb7
.word 0xa903ebb9
.word 0xaa0003f7
.word 0xf90027a1
.word 0xf9002ba2
.word 0xf9002fa3

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #312]
.word 0xf90033b0
.word 0xf9400a11
.word 0xf90037b1
.word 0xd2800016
.word 0xf94033b1
.word 0xf9405231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94037b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94033b1
.word 0xf9407231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94033b1
.word 0xf9408231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94027a0
.word 0xf9004fa0
.word 0xf94033b1
.word 0xf9409a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9404fa0
bl _p_13
.word 0xf9004ba0
.word 0xf94033b1
.word 0xf940b631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9404ba0
.word 0xaa0003f6
.word 0xf94033b1
.word 0xf940ce31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf90047a0
.word 0xf94033b1
.word 0xf940f231
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_21@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_21@PAGEOFF
ldr x0, [x0]
.word 0xf90043a0
.word 0xf94033b1
.word 0xf9411231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94043a0
.word 0xf94047a1
.word 0xaa1703e2
.word 0xaa0103f5
.word 0xaa0003f4
.word 0xb5000137
.word 0xaa1503e0
.word 0xaa1403e0

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #216]
.word 0xf9400000
.word 0xaa0003f3
.word 0x14000012
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1703e0
.word 0xf94033b1
.word 0xf9416631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1703e0
.word 0xf94002fe
bl _p_5
.word 0xf90043a0
.word 0xf94033b1
.word 0xf9418631
.word 0xb4000051
.word 0xd63f0220
.word 0xf94043a0
.word 0xaa0003f3
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1303e0
.word 0xaa1603e0
.word 0xf9402ba0
.word 0xf90047a0
.word 0xd2800000
.word 0xf94033b1
.word 0xf941ba31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94047a0
.word 0xd2800001
bl _p_22
.word 0x53001c00
.word 0xf90043a0
.word 0xf94033b1
.word 0xf941de31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94043a0
.word 0xaa1603fa
.word 0x34000160
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1303e0
.word 0xaa1a03e0

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #216]
.word 0xf9400000
.word 0xaa0003f9
.word 0x14000016
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1303e0
.word 0xaa1a03e0
.word 0xf9402ba0
.word 0xf90047a0
.word 0xf94033b1
.word 0xf9423a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94047a1
.word 0xaa0103e0
.word 0xf940003e
bl _p_23
.word 0xf90043a0
.word 0xf94033b1
.word 0xf9425e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94043a0
.word 0xaa0003f9
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1303e0
.word 0xaa1a03e0
.word 0xaa1903e0
.word 0xf9402fa0
.word 0xb5000180
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1303e0
.word 0xaa1a03e0
.word 0xaa1903e0

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #216]
.word 0xf9400000
.word 0xf9003fa0
.word 0x14000011
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1303e0
.word 0xaa1a03e0
.word 0xaa1903e0
.word 0xf9402fa0
.word 0xf90043a0
.word 0xf94033b1
.word 0xf942da31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94043a1
.word 0xaa0103e0
.word 0xf940003e
bl _p_5
.word 0xf9003fa0
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1303e0
.word 0xaa1a03e0
.word 0xaa1903e0
.word 0xf9403fa0
.word 0xf90043a0
.word 0xf94033b1
.word 0xf9431a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94043a5
.word 0xaa1503e0
.word 0xaa1403e1
.word 0xaa1303e2
.word 0xaa1a03e3
.word 0xaa1903e4
bl _p_30
.word 0xf94033b1
.word 0xf9434631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1603e0
.word 0xf94033b1
.word 0xf9435a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1603e0
bl _p_15
.word 0xf94033b1
.word 0xf9437231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94033b1
.word 0xf9438231
.word 0xb4000051
.word 0xd63f0220
.word 0xa94153b3
.word 0xa9425bb5
.word 0xf9401bb7
.word 0xa943ebb9
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0

Lme_27:
.text
	.align 4
	.no_dead_strip JPush_APService_SetTagsWithTarget_Foundation_NSSet_ObjCRuntime_Selector_Foundation_NSObject
JPush_APService_SetTagsWithTarget_Foundation_NSSet_ObjCRuntime_Selector_Foundation_NSObject:
.word 0xa9b87bfd
.word 0x910003fd
.word 0xa90153b3
.word 0xa9025bb5
.word 0xa90363b7
.word 0xa9046bb9
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #320]
.word 0xf9002bb0
.word 0xf9400a11
.word 0xf9002fb1
.word 0xf9402bb1
.word 0xf9404a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402bb1
.word 0xf9406a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402bb1
.word 0xf9407a31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf9003fa0
.word 0xf9402bb1
.word 0xf9409e31
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_22@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_22@PAGEOFF
ldr x0, [x0]
.word 0xf9003ba0
.word 0xf9402bb1
.word 0xf940be31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9403ba0
.word 0xf9403fa1
.word 0xaa1803e2
.word 0xaa0103f7
.word 0xaa0003f6
.word 0xb5000138
.word 0xaa1703e0
.word 0xaa1603e0

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #216]
.word 0xf9400000
.word 0xaa0003f5
.word 0x14000012
.word 0xaa1703e0
.word 0xaa1603e0
.word 0xaa1803e0
.word 0xf9402bb1
.word 0xf9411231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1803e0
.word 0xf940031e
bl _p_5
.word 0xf9003ba0
.word 0xf9402bb1
.word 0xf9413231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9403ba0
.word 0xaa0003f5
.word 0xaa1703e0
.word 0xaa1603e0
.word 0xaa1503e0
.word 0xaa1903e0
.word 0xd2800000
.word 0xf9402bb1
.word 0xf9415e31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xd2800001
bl _p_22
.word 0x53001c00
.word 0xf9003ba0
.word 0xf9402bb1
.word 0xf9418231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9403ba0
.word 0x34000140
.word 0xaa1703e0
.word 0xaa1603e0
.word 0xaa1503e0

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #216]
.word 0xf9400000
.word 0xaa0003f4
.word 0x14000013
.word 0xaa1703e0
.word 0xaa1603e0
.word 0xaa1503e0
.word 0xaa1903e0
.word 0xf9402bb1
.word 0xf941ce31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xf940033e
bl _p_23
.word 0xf9003ba0
.word 0xf9402bb1
.word 0xf941ee31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9403ba0
.word 0xaa0003f4
.word 0xaa1703e0
.word 0xaa1603e0
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1a03e0
.word 0xb500017a
.word 0xaa1703e0
.word 0xaa1603e0
.word 0xaa1503e0
.word 0xaa1403e0

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #216]
.word 0xf9400000
.word 0xaa0003f3
.word 0x1400000e
.word 0xaa1703e0
.word 0xaa1603e0
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1a03e0
.word 0xf9402bb1
.word 0xf9425a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf940035e
bl _p_5
.word 0xaa0003f3
.word 0xaa1703e0
.word 0xaa1603e0
.word 0xaa1503e0
.word 0xaa1403e0
.word 0xaa1303e0
.word 0xf9402bb1
.word 0xf9428e31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1703e0
.word 0xaa1603e1
.word 0xaa1503e2
.word 0xaa1403e3
.word 0xaa1303e4
bl _p_24
.word 0xf9402bb1
.word 0xf942b631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402bb1
.word 0xf942c631
.word 0xb4000051
.word 0xd63f0220
.word 0xa94153b3
.word 0xa9425bb5
.word 0xa94363b7
.word 0xa9446bb9
.word 0x910003bf
.word 0xa8c87bfd
.word 0xd65f03c0

Lme_28:
.text
	.align 4
	.no_dead_strip JPush_APService_SetupWithOption_Foundation_NSDictionary
JPush_APService_SetupWithOption_Foundation_NSDictionary:
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xa9026bb9
.word 0xaa0003fa

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #328]
.word 0xf9001bb0
.word 0xf9400a11
.word 0xf9001fb1
.word 0xf9401bb1
.word 0xf9403a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf9405a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf9406a31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf9002fa0
.word 0xf9401bb1
.word 0xf9408e31
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_23@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_23@PAGEOFF
ldr x0, [x0]
.word 0xf9002ba0
.word 0xf9401bb1
.word 0xf940ae31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402ba0
.word 0xf9402fa1
.word 0xaa1a03e2
.word 0xaa0103f9
.word 0xaa0003f8
.word 0xb500013a
.word 0xaa1903e0
.word 0xaa1803e0

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #216]
.word 0xf9400000
.word 0xaa0003f7
.word 0x1400000c
.word 0xaa1903e0
.word 0xaa1803e0
.word 0xaa1a03e0
.word 0xf9401bb1
.word 0xf9410231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf940035e
bl _p_5
.word 0xaa0003f7
.word 0xaa1903e0
.word 0xaa1803e0
.word 0xaa1703e0
.word 0xf9401bb1
.word 0xf9412e31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xaa1803e1
.word 0xaa1703e2
bl _p_17
.word 0xf9401bb1
.word 0xf9414e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf9415e31
.word 0xb4000051
.word 0xd63f0220
.word 0xa94163b7
.word 0xa9426bb9
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0

Lme_29:
.text
	.align 4
	.no_dead_strip JPush_APService_ShowLocalNotificationAtFront_UIKit_UILocalNotification_string
JPush_APService_ShowLocalNotificationAtFront_UIKit_UILocalNotification_string:
.word 0xa9b97bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #336]
.word 0xf90017b0
.word 0xf9400a11
.word 0xf9001bb1
.word 0xd2800018
.word 0xf94017b1
.word 0xf9404231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9406231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9407231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xb50002f9
.word 0xf94017b1
.word 0xf9408a31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd280dbe1
.word 0xd280dbe1
bl _p_11
.word 0xf90023a0
.word 0xf94017b1
.word 0xf940b631
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023a1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf94017b1
.word 0xf940e231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xb50002fa
.word 0xf94017b1
.word 0xf940fa31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801ea1
.word 0xd2801ea1
bl _p_11
.word 0xf90023a0
.word 0xf94017b1
.word 0xf9412631
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023a1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf94017b1
.word 0xf9415231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf94017b1
.word 0xf9416631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
bl _p_13
.word 0xf90037a0
.word 0xf94017b1
.word 0xf9418231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94037a0
.word 0xaa0003f8
.word 0xf94017b1
.word 0xf9419a31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf90027a0
.word 0xf94017b1
.word 0xf941be31
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_24@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_24@PAGEOFF
ldr x0, [x0]
.word 0xf9002ba0
.word 0xf94017b1
.word 0xf941de31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xf94017b1
.word 0xf941f231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xf940033e
bl _p_5
.word 0xf9002fa0
.word 0xf94017b1
.word 0xf9421231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1803e0
.word 0xf90033a0
.word 0xf94017b1
.word 0xf9422a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94027a0
.word 0xf9402ba1
.word 0xf9402fa2
.word 0xf94033a3
bl _p_31
.word 0xf94017b1
.word 0xf9424e31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1803e0
.word 0xf90023a0
.word 0xf94017b1
.word 0xf9426631
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023a0
bl _p_15
.word 0xf94017b1
.word 0xf9427e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9428e31
.word 0xb4000051
.word 0xd63f0220
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0

Lme_2a:
.text
	.align 4
	.no_dead_strip JPush_APService_StartLogPageView_string
JPush_APService_StartLogPageView_string:
.word 0xa9b97bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003fa

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #344]
.word 0xf90013b0
.word 0xf9400a11
.word 0xf90017b1
.word 0xd2800019
.word 0xf94013b1
.word 0xf9403a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9405a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9406a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xb50002fa
.word 0xf94013b1
.word 0xf9408231
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2800161
.word 0xd2800161
bl _p_11
.word 0xf90023a0
.word 0xf94013b1
.word 0xf940ae31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023a1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf94013b1
.word 0xf940da31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf94013b1
.word 0xf940ee31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
bl _p_13
.word 0xf90037a0
.word 0xf94013b1
.word 0xf9410a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94037a0
.word 0xf90033a0
.word 0xaa0003f9
.word 0xf94013b1
.word 0xf9412631
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf90027a0
.word 0xf94013b1
.word 0xf9414a31
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_25@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_25@PAGEOFF
ldr x0, [x0]
.word 0xf9002ba0
.word 0xf94013b1
.word 0xf9416a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94033a0
.word 0xf9002fa0
.word 0xf94013b1
.word 0xf9418231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94027a0
.word 0xf9402ba1
.word 0xf9402fa2
bl _p_17
.word 0xf94013b1
.word 0xf941a231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xf90023a0
.word 0xf94013b1
.word 0xf941ba31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023a0
bl _p_15
.word 0xf94013b1
.word 0xf941d231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf941e231
.word 0xb4000051
.word 0xd63f0220
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0

Lme_2b:
.text
	.align 4
	.no_dead_strip JPush_APService_StopLogPageView_string
JPush_APService_StopLogPageView_string:
.word 0xa9b97bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003fa

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #352]
.word 0xf90013b0
.word 0xf9400a11
.word 0xf90017b1
.word 0xd2800019
.word 0xf94013b1
.word 0xf9403a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9405a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9406a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xb50002fa
.word 0xf94013b1
.word 0xf9408231
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2800161
.word 0xd2800161
bl _p_11
.word 0xf90023a0
.word 0xf94013b1
.word 0xf940ae31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023a1
.word 0xd28007e0
.word 0xf2a04000
.word 0xd28007e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_12
.word 0xf94013b1
.word 0xf940da31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf94013b1
.word 0xf940ee31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
bl _p_13
.word 0xf90037a0
.word 0xf94013b1
.word 0xf9410a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94037a0
.word 0xf90033a0
.word 0xaa0003f9
.word 0xf94013b1
.word 0xf9412631
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf90027a0
.word 0xf94013b1
.word 0xf9414a31
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_26@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_26@PAGEOFF
ldr x0, [x0]
.word 0xf9002ba0
.word 0xf94013b1
.word 0xf9416a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94033a0
.word 0xf9002fa0
.word 0xf94013b1
.word 0xf9418231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94027a0
.word 0xf9402ba1
.word 0xf9402fa2
bl _p_17
.word 0xf94013b1
.word 0xf941a231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xf90023a0
.word 0xf94013b1
.word 0xf941ba31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023a0
bl _p_15
.word 0xf94013b1
.word 0xf941d231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf941e231
.word 0xb4000051
.word 0xd63f0220
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0

Lme_2c:
.text
	.align 4
	.no_dead_strip JPush_APService_get_RegistrationID
JPush_APService_get_RegistrationID:
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xf9000bba

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #360]
.word 0xf9000fb0
.word 0xf9400a11
.word 0xf90013b1
.word 0xd280001a
.word 0xf9400fb1
.word 0xf9403631
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9405631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9406631
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9400000
.word 0xf90027a0
.word 0xf9400fb1
.word 0xf9408a31
.word 0xb4000051
.word 0xd63f0220
adrp x0, L_OBJC_SELECTOR_REFERENCES_27@PAGE
add x0, x0, L_OBJC_SELECTOR_REFERENCES_27@PAGEOFF
ldr x0, [x0]
.word 0xf9002ba0
.word 0xf9400fb1
.word 0xf940aa31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94027a0
.word 0xf9402ba1
bl _p_6
.word 0xf90023a0
.word 0xf9400fb1
.word 0xf940ca31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023a0
bl _p_32
.word 0xf9001fa0
.word 0xf9400fb1
.word 0xf940e631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401fa0
.word 0xf9001ba0
.word 0xaa0003fa
.word 0xf9400fb1
.word 0xf9410231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401ba0
.word 0xaa0003e1
.word 0xf9400fb1
.word 0xf9411a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0

Lme_2d:
.text
	.align 4
	.no_dead_strip JPush_APService__cctor
JPush_APService__cctor:
.word 0xa9bc7bfd
.word 0x910003fd

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #368]
.word 0xf9000bb0
.word 0xf9400a11
.word 0xf9000fb1
.word 0xf9400bb1
.word 0xf9402e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400bb1
.word 0xf9404e31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #376]
bl _p_33
.word 0xf9001ba0
.word 0xf9400bb1
.word 0xf9407231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401ba1

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xf9000001
.word 0xf9400bb1
.word 0xf9409631
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_2e:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr:
.word 0xa9b37bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf90027be
.word 0xa90553b3
.word 0xa9065bb5
.word 0xa90763b7
.word 0xa9086bb9
.word 0xa90973bb
.word 0xf90053bd
.word 0x910003f1
.word 0xf90057b1
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #384]
.word 0xf90013b0
.word 0xf9400a11
.word 0xf90017b1
.word 0xf9005bbf
.word 0xf9005fbf
.word 0x390303bf
.word 0xd2800017

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #32]
bl _pthread_getspecific
.word 0x91004016
.word 0x9100e3a0
.word 0xf94002c1
.word 0xf9001fa1
.word 0xf90002c0
.word 0xf94013b1
.word 0xf9409231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf940b231
.word 0xb4000051
.word 0xd63f0220
.word 0x390303bf
.word 0xf94013b1
.word 0xf940c631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_34
.word 0xaa0003f7
.word 0xf94013b1
.word 0xf940e631
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #392]
.word 0xb9400000
.word 0x34000260
.word 0xf94013b1
.word 0xf9410a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9411a31
.word 0xb4000051
.word 0xd63f0220
bl _p_35
.word 0xaa0003f5
.word 0xaa1503e0
.word 0xaa1503e1
.word 0xaa0003f4
.word 0xb4000095
.word 0xaa1403e0
.word 0xaa1403e0
bl _p_12
.word 0xaa1403e0
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9416231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1703e0
.word 0x9100e3a0
.word 0xf9401fa0
.word 0xf90002c0
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9419231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1703e0
.word 0xf94013b1
.word 0xf941a631
.word 0xb4000051
.word 0xd63f0220
.word 0xa945d7b4
.word 0xa946dfb6
.word 0x910003bf
.word 0xa8cd7bfd
.word 0xd65f03c0

Lme_30:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr:
.word 0xa9b37bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf90027be
.word 0xa90553b3
.word 0xa9065bb5
.word 0xa90763b7
.word 0xa9086bb9
.word 0xa90973bb
.word 0xf90053bd
.word 0x910003f1
.word 0xf90057b1
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #400]
.word 0xf90013b0
.word 0xf9400a11
.word 0xf90017b1
.word 0xf9005bbf
.word 0xf9005fbf
.word 0x390303bf
.word 0xd2800017

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #32]
bl _pthread_getspecific
.word 0x91004016
.word 0x9100e3a0
.word 0xf94002c1
.word 0xf9001fa1
.word 0xf90002c0
.word 0xf94013b1
.word 0xf9409231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf940b231
.word 0xb4000051
.word 0xd63f0220
.word 0x390303bf
.word 0xf94013b1
.word 0xf940c631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_36
.word 0xaa0003f7
.word 0xf94013b1
.word 0xf940e631
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #392]
.word 0xb9400000
.word 0x34000260
.word 0xf94013b1
.word 0xf9410a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9411a31
.word 0xb4000051
.word 0xd63f0220
bl _p_35
.word 0xaa0003f5
.word 0xaa1503e0
.word 0xaa1503e1
.word 0xaa0003f4
.word 0xb4000095
.word 0xaa1403e0
.word 0xaa1403e0
bl _p_12
.word 0xaa1403e0
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9416231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1703e0
.word 0x9100e3a0
.word 0xf9401fa0
.word 0xf90002c0
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9419231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1703e0
.word 0xf94013b1
.word 0xf941a631
.word 0xb4000051
.word 0xd63f0220
.word 0xa945d7b4
.word 0xa946dfb6
.word 0x910003bf
.word 0xa8cd7bfd
.word 0xd65f03c0

Lme_31:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr:
.word 0xa9b37bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf9002bbe
.word 0xa905d3b3
.word 0xa906dbb5
.word 0xa907e3b7
.word 0xa908ebb9
.word 0xa909f3bb
.word 0xf90057bd
.word 0x910003f1
.word 0xf9005bb1
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #408]
.word 0xf90017b0
.word 0xf9400a11
.word 0xf9001bb1
.word 0xf9005fbf
.word 0xf90063bf
.word 0x390323bf
.word 0xd2800016

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #32]
bl _pthread_getspecific
.word 0x91004015
.word 0x910103a0
.word 0xf94002a1
.word 0xf90023a1
.word 0xf90002a0
.word 0xf94017b1
.word 0xf9409631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf940b631
.word 0xb4000051
.word 0xd63f0220
.word 0x390323bf
.word 0xf94017b1
.word 0xf940ca31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf94013a2
bl _p_37
.word 0xaa0003f6
.word 0xf94017b1
.word 0xf940ee31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #392]
.word 0xb9400000
.word 0x34000260
.word 0xf94017b1
.word 0xf9411231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9412231
.word 0xb4000051
.word 0xd63f0220
bl _p_35
.word 0xaa0003f4
.word 0xaa1403e0
.word 0xaa1403e1
.word 0xaa0003f3
.word 0xb4000094
.word 0xaa1303e0
.word 0xaa1303e0
bl _p_12
.word 0xaa1303e0
.word 0xf9401bb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9416a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1603e0
.word 0x910103a0
.word 0xf94023a0
.word 0xf90002a0
.word 0xf9401bb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9419a31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1603e0
.word 0xf94017b1
.word 0xf941ae31
.word 0xb4000051
.word 0xd63f0220
.word 0xa945d3b3
.word 0xa946dbb5
.word 0x910003bf
.word 0xa8cd7bfd
.word 0xd65f03c0

Lme_32:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr:
.word 0xa9b37bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf9002bbe
.word 0xa905d3b3
.word 0xa906dbb5
.word 0xa907e3b7
.word 0xa908ebb9
.word 0xa909f3bb
.word 0xf90057bd
.word 0x910003f1
.word 0xf9005bb1
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #416]
.word 0xf90017b0
.word 0xf9400a11
.word 0xf9001bb1
.word 0xf9005fbf
.word 0xf90063bf
.word 0x390323bf

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #32]
bl _pthread_getspecific
.word 0x91004016
.word 0x910103a0
.word 0xf94002c1
.word 0xf90023a1
.word 0xf90002c0
.word 0xf94017b1
.word 0xf9409231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf940b231
.word 0xb4000051
.word 0xd63f0220
.word 0x390323bf
.word 0xf94017b1
.word 0xf940c631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf94013a2
bl _p_38
.word 0xf94017b1
.word 0xf940e631
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #392]
.word 0xb9400000
.word 0x34000260
.word 0xf94017b1
.word 0xf9410a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9411a31
.word 0xb4000051
.word 0xd63f0220
bl _p_35
.word 0xaa0003f5
.word 0xaa1503e0
.word 0xaa1503e1
.word 0xaa0003f4
.word 0xb4000095
.word 0xaa1403e0
.word 0xaa1403e0
bl _p_12
.word 0xaa1403e0
.word 0xf9401bb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9416231
.word 0xb4000051
.word 0xd63f0220
.word 0x910103a0
.word 0xf94023a0
.word 0xf90002c0
.word 0xf94017b1
.word 0xf9417e31
.word 0xb4000051
.word 0xd63f0220
.word 0xa94657b4
.word 0xf9403bb6
.word 0x910003bf
.word 0xa8cd7bfd
.word 0xd65f03c0

Lme_33:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_nuint_IntPtr_intptr_intptr_System_nuint_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_nuint_IntPtr_intptr_intptr_System_nuint_intptr:
.word 0xa9b27bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf9002fbe
.word 0xa90653b3
.word 0xa9075bb5
.word 0xa90863b7
.word 0xa9096bb9
.word 0xa90a73bb
.word 0xf9005bbd
.word 0x910003f1
.word 0xf9005fb1
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #424]
.word 0xf9001bb0
.word 0xf9400a11
.word 0xf9001fb1
.word 0xf90063bf
.word 0xf90067bf
.word 0x390343bf

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #32]
bl _pthread_getspecific
.word 0x91004015
.word 0x910123a0
.word 0xf94002a1
.word 0xf90027a1
.word 0xf90002a0
.word 0xf9401bb1
.word 0xf9409631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf940b631
.word 0xb4000051
.word 0xd63f0220
.word 0x390343bf
.word 0xf9401bb1
.word 0xf940ca31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf94013a2
.word 0xf94017a3
bl _p_39
.word 0xf9401bb1
.word 0xf940ee31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #392]
.word 0xb9400000
.word 0x34000260
.word 0xf9401bb1
.word 0xf9411231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf9412231
.word 0xb4000051
.word 0xd63f0220
bl _p_35
.word 0xaa0003f4
.word 0xaa1403e0
.word 0xaa1403e1
.word 0xaa0003f3
.word 0xb4000094
.word 0xaa1303e0
.word 0xaa1303e0
bl _p_12
.word 0xaa1303e0
.word 0xf9401fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf9416a31
.word 0xb4000051
.word 0xd63f0220
.word 0x910123a0
.word 0xf94027a0
.word 0xf90002a0
.word 0xf9401bb1
.word 0xf9418631
.word 0xb4000051
.word 0xd63f0220
.word 0xa94653b3
.word 0xf9403bb5
.word 0x910003bf
.word 0xa8ce7bfd
.word 0xd65f03c0

Lme_34:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_intptr_intptr:
.word 0xa9b07bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf90037be
.word 0xa90753b3
.word 0xa9085bb5
.word 0xa90963b7
.word 0xa90a6bb9
.word 0xa90b73bb
.word 0xf90063bd
.word 0x910003f1
.word 0xf90067b1
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3
.word 0xf9001ba4
.word 0xf9001fa5

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #432]
.word 0xf90023b0
.word 0xf9400a11
.word 0xf90027b1
.word 0xf9006bbf
.word 0xf9006fbf
.word 0x390383bf

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #32]
bl _pthread_getspecific
.word 0x91004013
.word 0x910163a0
.word 0xf9400261
.word 0xf9002fa1
.word 0xf9000260
.word 0xf94023b1
.word 0xf9409e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94027b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023b1
.word 0xf940be31
.word 0xb4000051
.word 0xd63f0220
.word 0x390383bf
.word 0xf94023b1
.word 0xf940d231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf94013a2
.word 0xf94017a3
.word 0xf9401ba4
.word 0xf9401fa5
bl _p_40
.word 0xf94023b1
.word 0xf940fe31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #392]
.word 0xb9400000
.word 0x34000240
.word 0xf94023b1
.word 0xf9412231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023b1
.word 0xf9413231
.word 0xb4000051
.word 0xd63f0220
bl _p_35
.word 0xf90077a0
.word 0xf94077a1
.word 0xf94077a0
.word 0xf9007ba1
.word 0xb4000060
.word 0xf9407ba0
bl _p_12
.word 0xf9407ba0
.word 0xf94027b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023b1
.word 0xf9417631
.word 0xb4000051
.word 0xd63f0220
.word 0x910163a0
.word 0xf9402fa0
.word 0xf9000260
.word 0xf94023b1
.word 0xf9419231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9403bb3
.word 0x910003bf
.word 0xa8d07bfd
.word 0xd65f03c0

Lme_35:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_intptr:
.word 0xa9b17bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf90033be
.word 0xa906d3b3
.word 0xa907dbb5
.word 0xa908e3b7
.word 0xa909ebb9
.word 0xa90af3bb
.word 0xf9005fbd
.word 0x910003f1
.word 0xf90063b1
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3
.word 0xf9001ba4

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #440]
.word 0xf9001fb0
.word 0xf9400a11
.word 0xf90023b1
.word 0xf90067bf
.word 0xf9006bbf
.word 0x390363bf

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #32]
bl _pthread_getspecific
.word 0x91004014
.word 0x910143a0
.word 0xf9400281
.word 0xf9002ba1
.word 0xf9000280
.word 0xf9401fb1
.word 0xf9409a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94023b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401fb1
.word 0xf940ba31
.word 0xb4000051
.word 0xd63f0220
.word 0x390363bf
.word 0xf9401fb1
.word 0xf940ce31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf94013a2
.word 0xf94017a3
.word 0xf9401ba4
bl _p_41
.word 0xf9401fb1
.word 0xf940f631
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #392]
.word 0xb9400000
.word 0x34000240
.word 0xf9401fb1
.word 0xf9411a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401fb1
.word 0xf9412a31
.word 0xb4000051
.word 0xd63f0220
bl _p_35
.word 0xaa0003f3
.word 0xaa1303e0
.word 0xaa1303e1
.word 0xf90073a0
.word 0xb4000073
.word 0xf94073a0
bl _p_12
.word 0xf94073a0
.word 0xf94023b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401fb1
.word 0xf9416e31
.word 0xb4000051
.word 0xd63f0220
.word 0x910143a0
.word 0xf9402ba0
.word 0xf9000280
.word 0xf9401fb1
.word 0xf9418a31
.word 0xb4000051
.word 0xd63f0220
.word 0xa946d3b3
.word 0x910003bf
.word 0xa8cf7bfd
.word 0xd65f03c0

Lme_36:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_int_intptr_intptr_intptr_int
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_int_intptr_intptr_intptr_int:
.word 0xa9b27bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf9002fbe
.word 0xa90653b3
.word 0xa9075bb5
.word 0xa90863b7
.word 0xa9096bb9
.word 0xa90a73bb
.word 0xf9005bbd
.word 0x910003f1
.word 0xf9005fb1
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #448]
.word 0xf9001bb0
.word 0xf9400a11
.word 0xf9001fb1
.word 0xf90063bf
.word 0xf90067bf
.word 0x390343bf

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #32]
bl _pthread_getspecific
.word 0x91004015
.word 0x910123a0
.word 0xf94002a1
.word 0xf90027a1
.word 0xf90002a0
.word 0xf9401bb1
.word 0xf9409631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf940b631
.word 0xb4000051
.word 0xd63f0220
.word 0x390343bf
.word 0xf9401bb1
.word 0xf940ca31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf94013a2
.word 0xb9802ba3
bl _p_42
.word 0xf9401bb1
.word 0xf940ee31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #392]
.word 0xb9400000
.word 0x34000260
.word 0xf9401bb1
.word 0xf9411231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf9412231
.word 0xb4000051
.word 0xd63f0220
bl _p_35
.word 0xaa0003f4
.word 0xaa1403e0
.word 0xaa1403e1
.word 0xaa0003f3
.word 0xb4000094
.word 0xaa1303e0
.word 0xaa1303e0
bl _p_12
.word 0xaa1303e0
.word 0xf9401fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf9416a31
.word 0xb4000051
.word 0xd63f0220
.word 0x910123a0
.word 0xf94027a0
.word 0xf90002a0
.word 0xf9401bb1
.word 0xf9418631
.word 0xb4000051
.word 0xd63f0220
.word 0xa94653b3
.word 0xf9403bb5
.word 0x910003bf
.word 0xa8ce7bfd
.word 0xd65f03c0

Lme_37:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr:
.word 0xa9b37bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf90027be
.word 0xa90553b3
.word 0xa9065bb5
.word 0xa90763b7
.word 0xa9086bb9
.word 0xa90973bb
.word 0xf90053bd
.word 0x910003f1
.word 0xf90057b1
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #456]
.word 0xf90013b0
.word 0xf9400a11
.word 0xf90017b1
.word 0xf9005bbf
.word 0xf9005fbf
.word 0x390303bf

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #32]
bl _pthread_getspecific
.word 0x91004017
.word 0x9100e3a0
.word 0xf94002e1
.word 0xf9001fa1
.word 0xf90002e0
.word 0xf94013b1
.word 0xf9408e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf940ae31
.word 0xb4000051
.word 0xd63f0220
.word 0x390303bf
.word 0xf94013b1
.word 0xf940c231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_43
.word 0xf94013b1
.word 0xf940de31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #392]
.word 0xb9400000
.word 0x34000260
.word 0xf94013b1
.word 0xf9410231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9411231
.word 0xb4000051
.word 0xd63f0220
bl _p_35
.word 0xaa0003f6
.word 0xaa1603e0
.word 0xaa1603e1
.word 0xaa0003f5
.word 0xb4000096
.word 0xaa1503e0
.word 0xaa1503e0
bl _p_12
.word 0xaa1503e0
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9415a31
.word 0xb4000051
.word 0xd63f0220
.word 0x9100e3a0
.word 0xf9401fa0
.word 0xf90002e0
.word 0xf94013b1
.word 0xf9417631
.word 0xb4000051
.word 0xd63f0220
.word 0xa9465bb5
.word 0xf9403bb7
.word 0x910003bf
.word 0xa8cd7bfd
.word 0xd65f03c0

Lme_38:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_Double_Double_intptr_intptr_double_double
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_Double_Double_intptr_intptr_double_double:
.word 0xa9b27bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf9002fbe
.word 0xa90653b3
.word 0xa9075bb5
.word 0xa90863b7
.word 0xa9096bb9
.word 0xa90a73bb
.word 0xf9005bbd
.word 0x910003f1
.word 0xf9005fb1
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xfd0013a0
.word 0xfd0017a1

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #464]
.word 0xf9001bb0
.word 0xf9400a11
.word 0xf9001fb1
.word 0xf90063bf
.word 0xf90067bf
.word 0x390343bf

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #32]
bl _pthread_getspecific
.word 0x91004017
.word 0x910123a0
.word 0xf94002e1
.word 0xf90027a1
.word 0xf90002e0
.word 0xf9401bb1
.word 0xf9409631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf940b631
.word 0xb4000051
.word 0xd63f0220
.word 0x390343bf
.word 0xf9401bb1
.word 0xf940ca31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xfd4013a0
.word 0xfd4017a1
bl _p_44
.word 0xf9401bb1
.word 0xf940ee31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #392]
.word 0xb9400000
.word 0x34000260
.word 0xf9401bb1
.word 0xf9411231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf9412231
.word 0xb4000051
.word 0xd63f0220
bl _p_35
.word 0xaa0003f6
.word 0xaa1603e0
.word 0xaa1603e1
.word 0xaa0003f5
.word 0xb4000096
.word 0xaa1503e0
.word 0xaa1503e0
bl _p_12
.word 0xaa1503e0
.word 0xf9401fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf9416a31
.word 0xb4000051
.word 0xd63f0220
.word 0x910123a0
.word 0xf94027a0
.word 0xf90002e0
.word 0xf9401bb1
.word 0xf9418631
.word 0xb4000051
.word 0xd63f0220
.word 0xa9475bb5
.word 0xf94043b7
.word 0x910003bf
.word 0xa8ce7bfd
.word 0xd65f03c0

Lme_39:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_int_intptr_intptr_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_int_intptr_intptr_intptr_intptr:
.word 0xa9b07bfd
.word 0x910003fd
.word 0xd2800210
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0x1000001e
.word 0xf9003fbe
.word 0xa90853b3
.word 0xa9095bb5
.word 0xa90a63b7
.word 0xa90b6bb9
.word 0xa90c73bb
.word 0xf9006bbd
.word 0x910003f1
.word 0xf9006fb1
.word 0x910403bc
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3
.word 0xf9001ba4
.word 0xf9001fa5
.word 0xf90023a6
.word 0xf90027a7

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #472]
.word 0xf9002bb0
.word 0xf9400a11
.word 0xf9002fb1
.word 0xf90073bf
.word 0xf90077bf
.word 0x3903c3bf
.word 0xd2800019

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #32]
bl _pthread_getspecific
.word 0x91004018
.word 0x9101a3a0
.word 0xf9400301
.word 0xf90037a1
.word 0xf9000300
.word 0xf9402bb1
.word 0xf940be31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402bb1
.word 0xf940de31
.word 0xb4000051
.word 0xd63f0220
.word 0x3903c3bf
.word 0xf9402bb1
.word 0xf940f231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf94013a2
.word 0xf94017a3
.word 0xb98033a4
.word 0xf9401fa5
.word 0xf94023a6
.word 0xf94027a7
.word 0xf9400389
.word 0xf90003e9
bl _p_45
.word 0xaa0003f9
.word 0xf9402bb1
.word 0xf9413231
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #392]
.word 0xb9400000
.word 0x34000260
.word 0xf9402bb1
.word 0xf9415631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402bb1
.word 0xf9416631
.word 0xb4000051
.word 0xd63f0220
bl _p_35
.word 0xaa0003f7
.word 0xaa1703e0
.word 0xaa1703e1
.word 0xaa0003f6
.word 0xb4000097
.word 0xaa1603e0
.word 0xaa1603e0
bl _p_12
.word 0xaa1603e0
.word 0xf9402fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402bb1
.word 0xf941ae31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0x9101a3a0
.word 0xf94037a0
.word 0xf9000300
.word 0xf9402fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402bb1
.word 0xf941de31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xf9402bb1
.word 0xf941f231
.word 0xb4000051
.word 0xd63f0220
.word 0xa949dfb6
.word 0xa94ae7b8
.word 0xf94067bc
.word 0x910003bf
.word 0xa8d07bfd
.word 0xd65f03c0

Lme_3a:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool_IntPtr_intptr_intptr_intptr_intptr_int_intptr_intptr_intptr_intptr_intptr_bool_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool_IntPtr_intptr_intptr_intptr_intptr_int_intptr_intptr_intptr_intptr_intptr_bool_intptr:
.word 0xa9b07bfd
.word 0x910003fd
.word 0xd2800410
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0x1000001e
.word 0xf9003fbe
.word 0xa90853b3
.word 0xa9095bb5
.word 0xa90a63b7
.word 0xa90b6bb9
.word 0xa90c73bb
.word 0xf9006bbd
.word 0x910003f1
.word 0xf9006fb1
.word 0x910403bc
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3
.word 0xf9001ba4
.word 0xf9001fa5
.word 0xf90023a6
.word 0xf90027a7

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #480]
.word 0xf9002bb0
.word 0xf9400a11
.word 0xf9002fb1
.word 0xf90073bf
.word 0xf90077bf
.word 0x3903c3bf
.word 0xd2800018
.word 0xd2800017

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #32]
bl _pthread_getspecific
.word 0x91004016
.word 0x9101a3a0
.word 0xf94002c1
.word 0xf90037a1
.word 0xf90002c0
.word 0xf9402bb1
.word 0xf940c231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402bb1
.word 0xf940e231
.word 0xb4000051
.word 0xd63f0220
.word 0x3903c3bf
.word 0xf9402bb1
.word 0xf940f631
.word 0xb4000051
.word 0xd63f0220
.word 0x39404380
.word 0x340000c0
.word 0xf9402bb1
.word 0xf9410e31
.word 0xb4000051
.word 0xd63f0220
.word 0xd2800037
.word 0xf9402fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402bb1
.word 0xf9413231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf94013a2
.word 0xf94017a3
.word 0xb98033a4
.word 0xf9401fa5
.word 0xf94023a6
.word 0xf94027a7
.word 0xf940038b
.word 0xf940078a
.word 0xaa1703e9
.word 0xf9400f89
.word 0xf90003eb
.word 0xf90007ea
.word 0xb90013f7
.word 0xf9000fe9
bl _p_46
.word 0xaa0003f8
.word 0xf9402bb1
.word 0xf9418a31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #392]
.word 0xb9400000
.word 0x34000260
.word 0xf9402bb1
.word 0xf941ae31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402bb1
.word 0xf941be31
.word 0xb4000051
.word 0xd63f0220
bl _p_35
.word 0xaa0003f5
.word 0xaa1503e0
.word 0xaa1503e1
.word 0xaa0003f4
.word 0xb4000095
.word 0xaa1403e0
.word 0xaa1403e0
bl _p_12
.word 0xaa1403e0
.word 0xf9402fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402bb1
.word 0xf9420631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1803e0
.word 0x9101a3a0
.word 0xf94037a0
.word 0xf90002c0
.word 0xf9402fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402bb1
.word 0xf9423631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1803e0
.word 0xf9402bb1
.word 0xf9424a31
.word 0xb4000051
.word 0xd63f0220
.word 0xa948d7b4
.word 0xa949dfb6
.word 0xf94057b8
.word 0xf94067bc
.word 0x910003bf
.word 0xa8d07bfd
.word 0xd65f03c0

Lme_3b:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr:
.word 0xa9b27bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf9002fbe
.word 0xa90653b3
.word 0xa9075bb5
.word 0xa90863b7
.word 0xa9096bb9
.word 0xa90a73bb
.word 0xf9005bbd
.word 0x910003f1
.word 0xf9005fb1
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #488]
.word 0xf9001bb0
.word 0xf9400a11
.word 0xf9001fb1
.word 0xf90063bf
.word 0xf90067bf
.word 0x390343bf

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #32]
bl _pthread_getspecific
.word 0x91004015
.word 0x910123a0
.word 0xf94002a1
.word 0xf90027a1
.word 0xf90002a0
.word 0xf9401bb1
.word 0xf9409631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf940b631
.word 0xb4000051
.word 0xd63f0220
.word 0x390343bf
.word 0xf9401bb1
.word 0xf940ca31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf94013a2
.word 0xf94017a3
bl _p_47
.word 0xf9401bb1
.word 0xf940ee31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #392]
.word 0xb9400000
.word 0x34000260
.word 0xf9401bb1
.word 0xf9411231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf9412231
.word 0xb4000051
.word 0xd63f0220
bl _p_35
.word 0xaa0003f4
.word 0xaa1403e0
.word 0xaa1403e1
.word 0xaa0003f3
.word 0xb4000094
.word 0xaa1303e0
.word 0xaa1303e0
bl _p_12
.word 0xaa1303e0
.word 0xf9401fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf9416a31
.word 0xb4000051
.word 0xd63f0220
.word 0x910123a0
.word 0xf94027a0
.word 0xf90002a0
.word 0xf9401bb1
.word 0xf9418631
.word 0xb4000051
.word 0xd63f0220
.word 0xa94653b3
.word 0xf9403bb5
.word 0x910003bf
.word 0xa8ce7bfd
.word 0xd65f03c0

Lme_3c:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSend_nint_intptr_intptr_System_nint
wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSend_nint_intptr_intptr_System_nint:
.word 0xa9b37bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf9002bbe
.word 0xa905d3b3
.word 0xa906dbb5
.word 0xa907e3b7
.word 0xa908ebb9
.word 0xa909f3bb
.word 0xf90057bd
.word 0x910003f1
.word 0xf9005bb1
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #496]
.word 0xf90017b0
.word 0xf9400a11
.word 0xf9001bb1
.word 0xf9005fbf
.word 0xf90063bf
.word 0x390323bf
.word 0xd2800016

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #32]
bl _pthread_getspecific
.word 0x91004015
.word 0x910103a0
.word 0xf94002a1
.word 0xf90023a1
.word 0xf90002a0
.word 0xf94017b1
.word 0xf9409631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf940b631
.word 0xb4000051
.word 0xd63f0220
.word 0x390323bf
.word 0xf94017b1
.word 0xf940ca31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf94013a2
bl _p_48
.word 0x53001c00
.word 0xaa0003f6
.word 0xf94017b1
.word 0xf940f231
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x0, [x16, #392]
.word 0xb9400000
.word 0x34000260
.word 0xf94017b1
.word 0xf9411631
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9412631
.word 0xb4000051
.word 0xd63f0220
bl _p_35
.word 0xaa0003f4
.word 0xaa1403e0
.word 0xaa1403e1
.word 0xaa0003f3
.word 0xb4000094
.word 0xaa1303e0
.word 0xaa1303e0
bl _p_12
.word 0xaa1303e0
.word 0xf9401bb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9416e31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1603e0
.word 0x910103a0
.word 0xf94023a0
.word 0xf90002a0
.word 0xf9401bb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9419e31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1603e0
.word 0xf94017b1
.word 0xf941b231
.word 0xb4000051
.word 0xd63f0220
.word 0xa945d3b3
.word 0xa946dbb5
.word 0x910003bf
.word 0xa8cd7bfd
.word 0xd65f03c0

Lme_3d:
.text
	.align 3
jit_code_end:

	.byte 0,0,0,0
.text
	.align 3
method_addresses:
	.no_dead_strip method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl ApiDefinition_Messaging__cctor
bl JPush_APService__ctor
bl JPush_APService__ctor_Foundation_NSObjectFlag
bl JPush_APService__ctor_intptr
bl JPush_APService_get_ClassHandle
bl JPush_APService_BeginLogPageView_string_int
bl JPush_APService_ClearAllLocalNotifications
bl JPush_APService_CrashLogON
bl JPush_APService_DeleteLocalNotification_UIKit_UILocalNotification
bl JPush_APService_DeleteLocalNotificationWithIdentifierKey_string
bl JPush_APService_FilterValidTags_Foundation_NSSet
bl JPush_APService_FindLocalNotificationWithIdentifier_string
bl JPush_APService_HandleRemoteNotification_Foundation_NSDictionary
bl JPush_APService_RegisterDeviceToken_Foundation_NSData
bl JPush_APService_RegisterForRemoteNotificationTypes_System_nuint_Foundation_NSSet
bl JPush_APService_ResetBadge
bl JPush_APService_SetAlias_string_ObjCRuntime_Selector_Foundation_NSObject
bl JPush_APService_SetBadge_System_nint
bl JPush_APService_SetDebugMode
bl JPush_APService_SetLatitude_double_double
bl JPush_APService_SetLocalNotification_Foundation_NSDate_string_int_string_string_Foundation_NSDictionary_string
bl JPush_APService_SetLocalNotification_Foundation_NSDate_string_int_string_string_Foundation_NSDictionary_string_CoreLocation_CLRegion_bool_string
bl JPush_APService_SetLocation_CoreLocation_CLLocation
bl JPush_APService_SetLogOFF
bl JPush_APService_SetTagsWithObject_Foundation_NSSet_string_ObjCRuntime_Selector_Foundation_NSObject
bl JPush_APService_SetTagsWithTarger_Foundation_NSSet_string_ObjCRuntime_Selector_Foundation_NSObject
bl JPush_APService_SetTagsWithTarget_Foundation_NSSet_ObjCRuntime_Selector_Foundation_NSObject
bl JPush_APService_SetupWithOption_Foundation_NSDictionary
bl JPush_APService_ShowLocalNotificationAtFront_UIKit_UILocalNotification_string
bl JPush_APService_StartLogPageView_string
bl JPush_APService_StopLogPageView_string
bl JPush_APService_get_RegistrationID
bl JPush_APService__cctor
bl method_addresses
bl wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_nuint_IntPtr_intptr_intptr_System_nuint_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_int_intptr_intptr_intptr_int
bl wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_Double_Double_intptr_intptr_double_double
bl wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_int_intptr_intptr_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool_IntPtr_intptr_intptr_intptr_intptr_int_intptr_intptr_intptr_intptr_intptr_bool_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSend_nint_intptr_intptr_System_nint
method_addresses_end:

.section __TEXT, __const
	.align 3
unbox_trampolines:
unbox_trampolines_end:

	.long 0
.text
	.align 3
unbox_trampoline_addresses:

	.long 0
.section __TEXT, __const
	.align 3
method_info_offsets:

	.byte 62,0,0,0,10,0,0,0,7,0,0,0,2,0,0,0,0,0,10,0,20,0,30,0,40,0,56,0,67,0,0,0
	.byte 0,0,0,0,0,0,0,0,0,0,0,0,1,6,8,5,5,5,35,5,5,5,5,6,6,5,5,6,88,7,5,5
	.byte 5,6,6,5,5,8,128,148,8,6,5,5,5,5,255,255,255,255,74,128,188,6,128,200,6,6,6,6,6,6,6,6
	.byte 6,129,4,6
.section __TEXT, __const
	.align 3
extra_method_table:

	.byte 37,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
	.byte 0,0,0,0,0,0,0,0,120,1,0,0,61,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
	.byte 0,0,0,0,0,0,0,0,0,0,0,0,72,1,0,0,55,0,0,0,0,0,0,0,96,1,0,0,58,0,0,0
	.byte 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
	.byte 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,88,1,0,0,57,0,0,0,0,0,0,0
	.byte 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
	.byte 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
	.byte 0,0,0,0,0,0,0,0,16,1,0,0,48,0,0,0,39,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
	.byte 40,1,0,0,51,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
	.byte 0,0,0,0,32,1,0,0,50,0,0,0,37,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
	.byte 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
	.byte 24,1,0,0,49,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
	.byte 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
	.byte 0,0,0,0,0,0,0,0,64,1,0,0,54,0,0,0,38,0,0,0,48,1,0,0,52,0,0,0,0,0,0,0
	.byte 56,1,0,0,53,0,0,0,40,0,0,0,80,1,0,0,56,0,0,0,0,0,0,0,104,1,0,0,59,0,0,0
	.byte 0,0,0,0,112,1,0,0,60,0,0,0,0,0,0,0
.section __TEXT, __const
	.align 3
extra_method_info_offsets:

	.byte 14,0,0,0,48,0,0,0,16,1,0,0,49,0,0,0,24,1,0,0,50,0,0,0,32,1,0,0,51,0,0,0
	.byte 40,1,0,0,52,0,0,0,48,1,0,0,53,0,0,0,56,1,0,0,54,0,0,0,64,1,0,0,55,0,0,0
	.byte 72,1,0,0,56,0,0,0,80,1,0,0,57,0,0,0,88,1,0,0,58,0,0,0,96,1,0,0,59,0,0,0
	.byte 104,1,0,0,60,0,0,0,112,1,0,0,61,0,0,0,120,1,0,0
.section __TEXT, __const
	.align 3
class_name_table:

	.byte 11,0,1,0,11,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0,0,0,0,0
	.byte 0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0
.section __TEXT, __const
	.align 3
got_info_offsets:

	.byte 63,0,0,0,10,0,0,0,7,0,0,0,2,0,0,0,0,0,11,0,22,0,33,0,44,0,55,0,66,0,129,128
	.byte 2,1,1,1,1,1,7,4,1,129,154,3,1,1,1,4,1,1,1,1,129,169,1,12,1,12,1,1,1,7,1,129
	.byte 207,1,1,1,1,12,1,1,1,1,129,228,1,1,1,1,1,1,1,4,1,129,241,1,1,1,1,1,1,1,1,1
	.byte 129,251,1,1
.section __TEXT, __const
	.align 3
ex_info_offsets:

	.byte 62,0,0,0,10,0,0,0,7,0,0,0,2,0,0,0,0,0,10,0,24,0,42,0,58,0,80,0,100,0,0,0
	.byte 0,0,0,0,0,0,0,0,0,0,0,0,130,246,47,129,89,128,130,128,130,58,134,118,68,68,128,144,128,179,128,173
	.byte 128,220,128,144,128,144,128,151,139,197,129,43,99,68,90,130,146,131,120,128,144,68,129,117,151,185,129,42,128,136,129,1
	.byte 128,179,128,179,93,255,255,255,227,209,156,92,128,153,157,142,128,160,128,146,128,153,128,159,128,156,128,153,128,139,128,153
	.byte 128,204,164,22,128,153
.section __TEXT, __const
	.align 3
unwind_info:

	.byte 13,12,31,0,68,14,64,157,8,158,7,68,13,29,16,12,31,0,68,14,96,157,12,158,11,68,13,29,68,154,10,16
	.byte 12,31,0,68,14,96,157,12,158,11,68,13,29,68,153,10,16,12,31,0,68,14,64,157,8,158,7,68,13,29,68,154
	.byte 6,19,12,31,0,68,14,128,1,157,16,158,15,68,13,29,68,152,14,153,13,16,12,31,0,68,14,80,157,10,158,9
	.byte 68,13,29,68,154,8,18,12,31,0,68,14,112,157,14,158,13,68,13,29,68,153,12,154,11,24,12,31,0,68,14,144
	.byte 1,157,18,158,17,68,13,29,68,151,16,152,15,68,153,14,154,13,26,12,31,0,68,14,112,157,14,158,13,68,13,29
	.byte 68,149,12,150,11,68,151,10,152,9,68,154,8,32,12,31,0,68,14,176,1,157,22,158,21,68,13,29,68,147,20,148
	.byte 19,68,149,18,150,17,68,151,16,68,153,15,154,14,16,12,31,0,68,14,112,157,14,158,13,68,13,29,68,153,12,13
	.byte 12,31,0,68,14,96,157,12,158,11,68,13,29,30,12,31,0,68,14,176,2,157,38,158,37,68,13,29,84,147,36,148
	.byte 35,68,149,34,68,151,33,152,32,68,153,31,37,12,31,0,68,14,176,3,157,54,158,53,68,13,29,84,147,52,148,51
	.byte 68,149,50,150,49,68,151,48,152,47,68,153,46,154,45,68,156,44,32,12,31,0,68,14,160,1,157,20,158,19,68,13
	.byte 29,68,147,18,148,17,68,149,16,150,15,68,151,14,68,153,13,154,12,34,12,31,0,68,14,128,1,157,16,158,15,68
	.byte 13,29,68,147,14,148,13,68,149,12,150,11,68,151,10,152,9,68,153,8,154,7,23,12,31,0,68,14,96,157,12,158
	.byte 11,68,13,29,68,151,10,152,9,68,153,8,154,7,21,12,31,0,68,14,112,157,14,158,13,68,13,29,68,152,12,153
	.byte 11,68,154,10,39,12,31,0,68,14,208,1,157,26,158,25,68,13,29,76,147,16,148,15,68,149,14,150,13,68,151,12
	.byte 152,11,68,153,10,154,9,68,155,8,156,7,39,12,31,0,68,14,208,1,157,26,158,25,68,13,29,76,147,15,148,14
	.byte 68,149,13,150,12,68,151,11,152,10,68,153,9,154,8,68,155,7,156,6,39,12,31,0,68,14,224,1,157,28,158,27
	.byte 68,13,29,76,147,16,148,15,68,149,14,150,13,68,151,12,152,11,68,153,10,154,9,68,155,8,156,7,39,12,31,0
	.byte 68,14,128,2,157,32,158,31,68,13,29,76,147,18,148,17,68,149,16,150,15,68,151,14,152,13,68,153,12,154,11,68
	.byte 155,10,156,9,39,12,31,0,68,14,240,1,157,30,158,29,68,13,29,76,147,17,148,16,68,149,15,150,14,68,151,13
	.byte 152,12,68,153,11,154,10,68,155,9,156,8,39,12,31,0,68,14,128,2,157,32,158,31,68,13,29,92,147,16,148,15
	.byte 68,149,14,150,13,68,151,12,152,11,68,153,10,154,9,68,155,8,156,7
.section __TEXT, __const
	.align 3
class_info_offsets:

	.byte 3,0,0,0,10,0,0,0,1,0,0,0,2,0,0,0,0,0,165,81,7,24

.text
	.align 4
plt:
mono_aot_JPush_plt:
	.no_dead_strip plt_Foundation_NSObject__ctor_Foundation_NSObjectFlag
plt_Foundation_NSObject__ctor_Foundation_NSObjectFlag:
_p_1:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #512]
br x16
.word 510
	.no_dead_strip plt_System_Reflection_Assembly_op_Equality_System_Reflection_Assembly_System_Reflection_Assembly
plt_System_Reflection_Assembly_op_Equality_System_Reflection_Assembly_System_Reflection_Assembly:
_p_2:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #520]
br x16
.word 515
	.no_dead_strip plt_Foundation_NSObject_set_IsDirectBinding_bool
plt_Foundation_NSObject_set_IsDirectBinding_bool:
_p_3:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #528]
br x16
.word 520
	.no_dead_strip plt_Foundation_NSObject_get_IsDirectBinding
plt_Foundation_NSObject_get_IsDirectBinding:
_p_4:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #536]
br x16
.word 525
	.no_dead_strip plt_Foundation_NSObject_get_Handle
plt_Foundation_NSObject_get_Handle:
_p_5:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #544]
br x16
.word 530
	.no_dead_strip plt_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr
plt_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr:
_p_6:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #552]
br x16
.word 535
	.no_dead_strip plt_Foundation_NSObject_InitializeHandle_intptr_string
plt_Foundation_NSObject_InitializeHandle_intptr_string:
_p_7:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #560]
br x16
.word 537
	.no_dead_strip plt_Foundation_NSObject_get_SuperHandle
plt_Foundation_NSObject_get_SuperHandle:
_p_8:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #568]
br x16
.word 542
	.no_dead_strip plt_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr
plt_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr:
_p_9:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #576]
br x16
.word 547
	.no_dead_strip plt_Foundation_NSObject__ctor_intptr
plt_Foundation_NSObject__ctor_intptr:
_p_10:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #584]
br x16
.word 549
	.no_dead_strip plt__jit_icall_mono_helper_ldstr
plt__jit_icall_mono_helper_ldstr:
_p_11:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #592]
br x16
.word 554
	.no_dead_strip plt__jit_icall_mono_arch_throw_exception
plt__jit_icall_mono_arch_throw_exception:
_p_12:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #600]
br x16
.word 574
	.no_dead_strip plt_Foundation_NSString_CreateNative_string
plt_Foundation_NSString_CreateNative_string:
_p_13:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #608]
br x16
.word 602
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_int_intptr_intptr_intptr_int
plt_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_int_intptr_intptr_intptr_int:
_p_14:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #616]
br x16
.word 607
	.no_dead_strip plt_Foundation_NSString_ReleaseNative_intptr
plt_Foundation_NSString_ReleaseNative_intptr:
_p_15:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #624]
br x16
.word 609
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr
plt_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr:
_p_16:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #632]
br x16
.word 614
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr
plt_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr:
_p_17:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #640]
br x16
.word 616
	.no_dead_strip plt_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr
plt_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr:
_p_18:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #648]
br x16
.word 618
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_Foundation_NSSet_intptr
plt_ObjCRuntime_Runtime_GetNSObject_Foundation_NSSet_intptr:
_p_19:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #656]
br x16
.word 620
	.no_dead_strip plt_Foundation_NSArray_ArrayFromHandle_UIKit_UILocalNotification_intptr
plt_Foundation_NSArray_ArrayFromHandle_UIKit_UILocalNotification_intptr:
_p_20:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #664]
br x16
.word 632
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSend_nuint_IntPtr_intptr_intptr_System_nuint_intptr
plt_ApiDefinition_Messaging_void_objc_msgSend_nuint_IntPtr_intptr_intptr_System_nuint_intptr:
_p_21:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #672]
br x16
.word 644
	.no_dead_strip plt_ObjCRuntime_Selector_op_Equality_ObjCRuntime_Selector_ObjCRuntime_Selector
plt_ObjCRuntime_Selector_op_Equality_ObjCRuntime_Selector_ObjCRuntime_Selector:
_p_22:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #680]
br x16
.word 646
	.no_dead_strip plt_ObjCRuntime_Selector_get_Handle
plt_ObjCRuntime_Selector_get_Handle:
_p_23:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #688]
br x16
.word 651
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_intptr
plt_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_intptr:
_p_24:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #696]
br x16
.word 656
	.no_dead_strip plt_ApiDefinition_Messaging_bool_objc_msgSend_nint_intptr_intptr_System_nint
plt_ApiDefinition_Messaging_bool_objc_msgSend_nint_intptr_intptr_System_nint:
_p_25:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #704]
br x16
.word 658
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSend_Double_Double_intptr_intptr_double_double
plt_ApiDefinition_Messaging_void_objc_msgSend_Double_Double_intptr_intptr_double_double:
_p_26:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #712]
br x16
.word 660
	.no_dead_strip plt_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_int_intptr_intptr_intptr_intptr
plt_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_int_intptr_intptr_intptr_intptr:
_p_27:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #720]
br x16
.word 662
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_UIKit_UILocalNotification_intptr
plt_ObjCRuntime_Runtime_GetNSObject_UIKit_UILocalNotification_intptr:
_p_28:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #728]
br x16
.word 664
	.no_dead_strip plt_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool_IntPtr_intptr_intptr_intptr_intptr_int_intptr_intptr_intptr_intptr_intptr_bool_intptr
plt_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool_IntPtr_intptr_intptr_intptr_intptr_int_intptr_intptr_intptr_intptr_intptr_bool_intptr:
_p_29:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #736]
br x16
.word 676
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_intptr_intptr
plt_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_intptr_intptr:
_p_30:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #744]
br x16
.word 678
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr
plt_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr:
_p_31:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #752]
br x16
.word 680
	.no_dead_strip plt_Foundation_NSString_FromHandle_intptr
plt_Foundation_NSString_FromHandle_intptr:
_p_32:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #760]
br x16
.word 682
	.no_dead_strip plt_ObjCRuntime_Class_GetHandle_string
plt_ObjCRuntime_Class_GetHandle_string:
_p_33:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #768]
br x16
.word 687
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr:
_p_34:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #776]
br x16
.word 692
	.no_dead_strip plt__jit_icall_mono_thread_interruption_checkpoint
plt__jit_icall_mono_thread_interruption_checkpoint:
_p_35:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #784]
br x16
.word 694
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr:
_p_36:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #792]
br x16
.word 732
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr:
_p_37:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #800]
br x16
.word 734
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr:
_p_38:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #808]
br x16
.word 736
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_nuint_IntPtr_intptr_intptr_System_nuint_intptr
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_nuint_IntPtr_intptr_intptr_System_nuint_intptr:
_p_39:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #816]
br x16
.word 738
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_intptr_intptr:
_p_40:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #824]
br x16
.word 740
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_intptr:
_p_41:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #832]
br x16
.word 742
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_int_intptr_intptr_intptr_int
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_int_intptr_intptr_intptr_int:
_p_42:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #840]
br x16
.word 744
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr:
_p_43:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #848]
br x16
.word 746
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_Double_Double_intptr_intptr_double_double
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_Double_Double_intptr_intptr_double_double:
_p_44:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #856]
br x16
.word 748
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_int_intptr_intptr_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_int_intptr_intptr_intptr_intptr:
_p_45:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #864]
br x16
.word 750
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool_IntPtr_intptr_intptr_intptr_intptr_int_intptr_intptr_intptr_intptr_intptr_bool_intptr
plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool_IntPtr_intptr_intptr_intptr_intptr_int_intptr_intptr_intptr_intptr_intptr_bool_intptr:
_p_46:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #872]
br x16
.word 752
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr:
_p_47:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #880]
br x16
.word 754
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_bool_objc_msgSend_nint_intptr_intptr_System_nint
plt__icall_native_ApiDefinition_Messaging_bool_objc_msgSend_nint_intptr_intptr_System_nint:
_p_48:
adrp x16, mono_aot_JPush_got@PAGE+0
add x16, x16, mono_aot_JPush_got@PAGEOFF
ldr x16, [x16, #888]
br x16
.word 756
plt_end:
.section __TEXT, __const
	.align 3
image_table:

	.byte 3,0,0,0,74,80,117,115,104,0,66,67,54,55,53,48,67,68,45,51,51,48,56,45,52,67,65,50,45,65,52,48
	.byte 49,45,50,55,50,70,55,55,66,69,56,56,50,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0
	.byte 0,0,0,0,219,22,0,0,173,96,0,0,88,97,109,97,114,105,110,46,105,79,83,0,52,65,67,48,66,69,66,52
	.byte 45,70,56,65,53,45,52,50,68,52,45,66,56,55,49,45,66,53,54,50,69,52,50,56,54,69,65,65,0,0,56,52
	.byte 101,48,52,102,102,57,99,102,98,55,57,48,54,53,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
	.byte 0,0,0,0,109,115,99,111,114,108,105,98,0,54,67,66,49,50,52,69,52,45,55,67,57,53,45,52,52,48,50,45
	.byte 56,48,48,68,45,53,56,70,68,65,57,55,67,67,49,66,54,0,0,55,99,101,99,56,53,100,55,98,101,97,55,55
	.byte 57,56,101,0,0,0,0,0,1,0,0,0,2,0,0,0,0,0,0,0,5,0,0,0,0,0,0,0
.section __DATA, __bss
	.align 3
.lcomm mono_aot_JPush_got, 896
.section __TEXT, __const
	.align 2
runtime_version:
	.asciz ""
.section __TEXT, __const
	.align 2
assembly_guid:
	.asciz "BC6750CD-3308-4CA2-A401-272F77BE8822"
.section __TEXT, __const
	.align 2
assembly_name:
	.asciz "JPush"
.data
	.align 3
_mono_aot_file_info:

	.long 119,0
	.align 3
	.quad mono_aot_JPush_got
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad jit_code_start
	.align 3
	.quad jit_code_end
	.align 3
	.quad method_addresses
	.align 3
	.quad blob
	.align 3
	.quad class_name_table
	.align 3
	.quad class_info_offsets
	.align 3
	.quad method_info_offsets
	.align 3
	.quad ex_info_offsets
	.align 3
	.quad extra_method_info_offsets
	.align 3
	.quad extra_method_table
	.align 3
	.quad got_info_offsets
	.align 3
	.quad 0
	.align 3
	.quad mem_end
	.align 3
	.quad image_table
	.align 3
	.quad assembly_guid
	.align 3
	.quad runtime_version
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad globals
	.align 3
	.quad assembly_name
	.align 3
	.quad plt
	.align 3
	.quad plt_end
	.align 3
	.quad unwind_info
	.align 3
	.quad unbox_trampolines
	.align 3
	.quad unbox_trampolines_end
	.align 3
	.quad unbox_trampoline_addresses

	.long 63,896,49,62,6,387000831,0,9773
	.long 128,8,8,15,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0,0,0,0,0
	.globl _mono_aot_module_JPush_info
	.align 3
_mono_aot_module_JPush_info:
	.align 3
	.quad _mono_aot_file_info
.section __TEXT, __const
	.align 3
blob:

	.byte 0,1,2,3,5,6,7,1,3,5,8,9,7,10,10,1,3,2,11,7,1,3,2,12,7,1,3,2,13,14,1,3
	.byte 2,15,14,1,3,2,16,14,1,3,2,17,14,1,3,2,18,14,1,3,2,19,14,1,3,3,20,14,21,1,3,3
	.byte 22,14,23,1,3,2,24,14,1,3,2,25,14,1,3,3,26,14,27,1,3,2,28,14,1,3,4,29,14,27,27,1
	.byte 3,2,30,14,1,3,2,31,14,1,3,2,32,14,1,3,3,33,14,34,1,3,3,35,14,34,1,3,2,36,14,1
	.byte 3,2,37,14,1,3,5,38,14,27,27,27,1,3,5,39,14,27,27,27,1,3,5,40,14,27,27,27,1,3,3,41
	.byte 14,27,1,3,2,42,14,1,3,2,43,14,1,3,2,44,14,1,3,2,45,14,1,3,3,46,47,14,1,2,3,48
	.byte 4,49,1,2,3,50,4,49,1,2,3,51,4,49,1,2,3,52,4,49,1,2,3,53,4,49,1,2,3,54,4,49
	.byte 1,2,3,55,4,49,1,2,3,56,4,49,1,2,3,57,4,49,1,2,3,58,4,49,1,2,3,59,4,49,1,2
	.byte 3,60,4,49,1,2,3,61,4,49,1,2,3,62,4,49,255,252,0,0,0,6,17,1,255,252,0,0,0,6,17,2
	.byte 255,252,0,0,0,6,17,3,255,252,0,0,0,6,17,4,255,252,0,0,0,6,17,5,255,252,0,0,0,6,17,6
	.byte 255,252,0,0,0,6,17,7,255,252,0,0,0,6,17,8,255,252,0,0,0,6,17,9,255,252,0,0,0,6,17,10
	.byte 255,252,0,0,0,6,17,11,255,252,0,0,0,6,17,12,255,252,0,0,0,6,17,13,255,252,0,0,0,6,17,14
	.byte 12,0,39,42,52,47,40,19,0,194,0,0,2,0,16,1,2,1,40,16,2,128,177,1,129,168,17,0,1,40,40,40
	.byte 16,1,3,2,40,40,40,40,40,40,34,255,254,0,0,0,0,255,43,0,0,1,40,34,255,254,0,0,0,0,255,43
	.byte 0,0,2,40,40,40,16,2,132,46,2,144,138,40,40,40,40,40,40,34,255,254,0,0,0,0,255,43,0,0,3,40
	.byte 40,40,40,40,40,40,40,40,40,40,40,17,0,135,181,40,33,40,40,40,40,40,40,40,40,40,40,40,40,40,3,193
	.byte 0,6,8,3,194,0,28,241,3,193,0,6,16,3,193,0,6,15,3,193,0,6,36,3,1,3,193,0,6,38,3,193
	.byte 0,6,35,3,2,3,193,0,6,9,7,17,109,111,110,111,95,104,101,108,112,101,114,95,108,100,115,116,114,0,7,25
	.byte 109,111,110,111,95,97,114,99,104,95,116,104,114,111,119,95,101,120,99,101,112,116,105,111,110,0,3,193,0,2,53,3
	.byte 8,3,193,0,2,56,3,9,3,4,3,3,3,255,254,0,0,0,0,255,43,0,0,1,3,255,254,0,0,0,0,255
	.byte 43,0,0,2,3,5,3,193,0,5,189,3,193,0,5,187,3,7,3,14,3,10,3,11,3,255,254,0,0,0,0,255
	.byte 43,0,0,3,3,12,3,6,3,13,3,193,0,2,59,3,193,0,4,82,31,1,7,35,109,111,110,111,95,116,104,114
	.byte 101,97,100,95,105,110,116,101,114,114,117,112,116,105,111,110,95,99,104,101,99,107,112,111,105,110,116,0,31,2,31,3
	.byte 31,4,31,5,31,6,31,7,31,8,31,9,31,10,31,11,31,12,31,13,31,14,10,0,1,17,1,64,0,0,2,64
	.byte 0,1,2,30,96,1,0,0,72,2,0,25,128,164,48,128,176,0,9,0,48,0,32,10,12,0,4,0,4,0,12,5
	.byte 20,0,12,6,20,10,14,1,158,1,1,80,0,0,2,64,0,1,2,22,88,0,1,3,2,32,0,1,4,4,48,0
	.byte 1,5,10,56,0,1,6,10,80,1,1,7,10,72,0,1,8,10,72,0,1,9,10,56,0,1,10,2,40,0,1,11
	.byte 10,64,1,2,12,21,10,48,0,1,13,2,32,0,1,14,4,48,0,1,15,10,56,1,1,16,10,32,0,1,17,10
	.byte 64,0,1,18,10,64,1,1,19,10,64,0,1,20,10,64,0,1,30,12,40,0,1,22,2,32,0,1,23,4,48,0
	.byte 1,24,10,56,1,1,25,10,32,0,1,26,10,64,0,1,27,10,64,1,1,28,10,64,0,1,29,10,64,0,1,30
	.byte 2,64,0,0,0,32,2,0,128,180,131,140,56,131,156,26,0,86,0,56,0,32,1,4,0,12,5,4,0,4,0,0
	.byte 5,4,1,16,0,16,1,4,1,4,0,16,0,4,5,8,0,20,0,4,0,4,0,12,5,16,0,12,5,8,0,24
	.byte 0,0,0,0,0,4,5,8,0,20,0,4,0,0,5,4,0,16,1,4,0,16,0,4,0,4,0,8,5,20,0,0
	.byte 5,4,1,16,0,16,1,4,1,4,0,16,0,4,0,8,10,16,0,16,5,16,0,24,0,0,0,0,0,8,5,16
	.byte 5,16,0,24,0,4,0,0,0,0,5,4,1,16,5,4,1,16,0,16,1,4,1,4,0,16,0,4,0,8,10,16
	.byte 0,16,5,16,0,24,0,0,0,0,0,8,5,16,5,16,0,24,0,4,0,0,0,0,5,4,1,16,1,48,10,31
	.byte 1,52,1,88,0,0,2,64,0,1,2,14,64,0,1,3,2,32,0,1,4,4,48,0,1,5,10,56,0,1,6,10
	.byte 80,1,1,7,10,72,0,1,8,10,72,0,1,9,10,56,0,0,0,32,2,0,73,129,92,60,129,108,208,0,0,29
	.byte 24,25,0,30,0,60,0,32,2,8,0,4,0,0,5,4,1,16,0,16,1,4,1,4,0,16,0,4,5,8,0,20
	.byte 0,4,0,4,0,12,5,16,0,12,5,8,0,24,0,0,0,0,0,4,5,8,0,20,0,4,0,0,5,4,1,32
	.byte 10,31,1,52,1,88,0,0,2,64,0,1,2,14,64,0,1,3,2,32,0,1,4,4,48,0,1,5,10,56,0,1
	.byte 6,10,80,1,1,7,10,72,0,1,8,10,72,0,1,9,10,56,0,0,0,32,2,0,73,129,92,60,129,108,208,0
	.byte 0,29,24,25,0,30,0,60,0,32,2,8,0,4,0,0,5,4,1,16,0,16,1,4,1,4,0,16,0,4,5,8
	.byte 0,20,0,4,0,4,0,12,5,16,0,12,5,8,0,24,0,0,0,0,0,4,5,8,0,20,0,4,0,0,5,4
	.byte 1,32,10,48,1,22,1,88,0,0,2,64,0,1,2,2,32,0,1,3,22,72,0,0,0,48,2,0,31,128,168,60
	.byte 128,184,208,0,0,29,24,26,0,9,0,60,1,32,0,16,0,12,5,4,6,4,0,16,1,4,1,20,10,65,1,77
	.byte 1,96,0,0,2,64,0,1,2,2,32,0,2,3,5,12,48,0,1,4,10,88,0,0,12,88,0,1,6,2,40,0
	.byte 1,7,10,56,1,1,8,2,56,0,1,9,20,72,0,1,10,10,64,1,1,11,4,64,0,1,12,10,72,0,1,13
	.byte 2,48,0,1,14,10,48,0,0,0,32,2,0,104,129,244,64,130,4,25,208,0,0,29,32,24,0,45,0,64,1,32
	.byte 0,16,1,4,0,0,5,4,0,16,0,12,0,4,0,0,0,4,5,8,0,20,0,8,0,8,0,0,5,4,0,4
	.byte 1,0,0,16,1,4,0,16,0,4,0,8,5,24,1,4,0,16,0,12,10,8,0,16,0,16,5,24,2,8,0,32
	.byte 0,0,0,0,0,0,0,0,5,4,0,16,1,8,0,20,0,0,5,4,1,32,10,0,1,32,1,64,0,0,2,64
	.byte 0,1,2,2,32,0,1,3,20,72,0,1,4,10,64,0,1,5,10,56,0,0,0,32,2,0,31,128,208,48,128,220
	.byte 0,12,0,48,1,32,0,16,0,12,10,8,0,16,5,16,0,24,0,0,0,0,5,4,1,32,10,0,1,32,1,64
	.byte 0,0,2,64,0,1,2,2,32,0,1,3,20,72,0,1,4,10,64,0,1,5,10,56,0,0,0,32,2,0,31,128
	.byte 208,48,128,220,0,12,0,48,1,32,0,16,0,12,10,8,0,16,5,16,0,24,0,0,0,0,5,4,1,32,10,85
	.byte 1,57,1,80,0,0,2,64,0,1,2,2,32,0,2,3,5,12,48,0,1,4,10,88,0,0,12,88,0,1,6,20
	.byte 72,0,1,7,10,64,1,1,8,2,40,0,1,9,10,64,0,1,10,10,64,0,0,0,32,2,0,82,129,128,56,129
	.byte 144,26,0,37,0,56,1,32,0,16,1,4,0,0,5,4,0,16,0,12,0,4,0,0,0,4,5,8,0,20,0,8
	.byte 0,8,0,0,5,4,0,4,1,0,0,16,0,12,10,8,0,16,0,16,5,16,1,4,0,16,0,4,0,4,0,0
	.byte 5,8,0,28,0,0,0,0,0,0,5,4,1,32,10,102,1,77,1,88,0,0,2,64,0,1,2,2,32,0,2,3
	.byte 5,12,48,0,1,4,10,88,0,0,12,88,0,1,6,2,40,0,1,7,10,56,1,1,8,2,56,0,1,9,20,72
	.byte 0,1,10,10,64,1,1,11,2,48,0,1,12,10,64,0,1,13,2,48,0,1,14,10,48,0,0,0,32,2,0,97
	.byte 129,228,60,129,244,26,25,0,44,0,60,1,32,0,16,1,4,0,0,5,4,0,16,0,12,0,4,0,0,0,4,5
	.byte 8,0,20,0,8,0,8,0,0,5,4,0,4,1,0,0,16,1,4,0,16,0,4,0,8,5,24,1,4,0,16,0
	.byte 12,10,8,0,16,0,16,5,24,1,0,0,28,0,0,0,0,0,0,5,4,0,16,1,8,0,20,0,0,5,4,1
	.byte 32,10,102,1,67,1,88,0,0,2,64,0,1,2,2,32,0,2,3,5,12,48,0,1,4,10,88,0,0,12,88,0
	.byte 1,6,20,72,0,1,7,10,64,1,1,8,2,40,0,1,9,10,64,0,1,10,10,72,0,1,11,10,80,1,1,12
	.byte 12,56,0,0,0,48,2,0,101,129,212,60,129,228,26,25,0,46,0,60,1,32,0,16,1,4,0,0,5,4,0,16
	.byte 0,12,0,4,0,0,0,4,5,8,0,20,0,8,0,8,0,0,5,4,0,4,1,0,0,16,0,12,10,8,0,16
	.byte 0,16,5,16,1,4,0,16,0,4,0,4,0,0,5,8,0,28,0,0,0,0,0,0,5,8,0,20,0,12,0,0
	.byte 0,0,0,8,5,24,6,4,0,20,1,4,1,16,10,121,1,92,1,112,0,0,2,64,0,1,2,2,32,0,2,3
	.byte 5,12,48,0,1,4,10,88,0,0,12,88,0,1,6,2,40,0,1,7,10,56,1,1,8,2,56,0,1,9,20,72
	.byte 0,1,10,10,64,1,1,11,2,48,0,1,12,10,72,0,1,13,10,80,1,1,14,2,48,0,1,15,2,48,0,1
	.byte 16,10,48,0,1,17,14,48,0,0,0,48,2,0,123,130,84,72,130,104,26,25,24,23,0,56,0,72,1,32,0,16
	.byte 1,4,0,0,5,4,0,16,0,12,0,4,0,0,0,4,5,8,0,20,0,8,0,8,0,0,5,4,0,4,1,0
	.byte 0,16,1,4,0,16,0,4,0,8,5,24,1,4,0,16,0,12,10,8,0,16,0,16,5,24,1,0,0,28,0,0
	.byte 0,0,0,0,5,8,0,20,0,12,0,0,0,0,0,8,5,20,1,4,0,16,1,8,0,20,0,0,5,4,0,16
	.byte 1,4,6,4,0,16,1,4,1,20,10,85,1,57,1,80,0,0,2,64,0,1,2,2,32,0,2,3,5,12,48,0
	.byte 1,4,10,88,0,0,12,88,0,1,6,20,72,0,1,7,10,64,1,1,8,2,40,0,1,9,10,64,0,1,10,10
	.byte 64,0,0,0,32,2,0,82,129,128,56,129,144,26,0,37,0,56,1,32,0,16,1,4,0,0,5,4,0,16,0,12
	.byte 0,4,0,0,0,4,5,8,0,20,0,8,0,8,0,0,5,4,0,4,1,0,0,16,0,12,10,8,0,16,0,16
	.byte 5,16,1,4,0,16,0,4,0,4,0,0,5,8,0,28,0,0,0,0,0,0,5,4,1,32,10,85,1,57,1,80
	.byte 0,0,2,64,0,1,2,2,32,0,2,3,5,12,48,0,1,4,10,88,0,0,12,88,0,1,6,20,72,0,1,7
	.byte 10,64,1,1,8,2,40,0,1,9,10,64,0,1,10,10,64,0,0,0,32,2,0,82,129,128,56,129,144,26,0,37
	.byte 0,56,1,32,0,16,1,4,0,0,5,4,0,16,0,12,0,4,0,0,0,4,5,8,0,20,0,8,0,8,0,0
	.byte 5,4,0,4,1,0,0,16,0,12,10,8,0,16,0,16,5,16,1,4,0,16,0,4,0,4,0,0,5,8,0,28
	.byte 0,0,0,0,0,0,5,4,1,32,10,128,146,1,44,1,104,0,0,2,64,0,1,2,2,32,0,1,3,20,72,0
	.byte 1,4,10,64,1,2,5,6,36,200,1,0,1,6,10,96,0,1,7,10,72,0,0,0,32,2,0,101,129,128,68,129
	.byte 152,208,0,0,29,56,26,0,42,0,68,1,32,0,16,0,12,10,8,0,16,0,16,6,28,255,255,255,255,240,4,10
	.byte 4,5,4,2,4,0,0,5,4,0,4,0,4,0,4,0,12,0,4,5,4,5,4,0,4,0,4,0,4,1,4,0
	.byte 16,0,4,0,4,0,0,0,4,5,4,0,4,0,4,0,4,0,4,0,16,0,4,0,4,0,4,0,4,5,4,1
	.byte 32,10,0,1,32,1,64,0,0,2,64,0,1,2,2,32,0,1,3,20,72,0,1,4,10,64,0,1,5,10,56,0
	.byte 0,0,32,2,0,31,128,208,48,128,220,0,12,0,48,1,32,0,16,0,12,10,8,0,16,5,16,0,24,0,0,0
	.byte 0,5,4,1,32,10,128,173,1,93,1,128,1,0,0,2,64,0,1,2,2,32,0,1,3,2,48,0,1,4,10,56
	.byte 1,1,5,2,56,0,1,6,20,72,0,1,7,10,64,1,1,8,6,64,0,1,9,10,72,1,3,10,12,13,32,200
	.byte 1,0,1,11,10,64,1,2,12,13,34,224,1,0,1,13,10,112,0,1,14,10,80,0,1,15,2,40,0,1,16,10
	.byte 48,0,0,0,32,2,0,128,199,130,232,80,131,4,208,0,0,29,72,25,208,0,0,29,80,23,0,88,0,80,1,32
	.byte 1,24,0,20,0,0,0,8,5,24,1,4,0,16,0,12,10,8,0,16,0,16,5,20,1,4,1,4,1,4,0,16
	.byte 0,4,0,4,0,4,0,8,255,255,255,255,238,32,10,4,5,4,8,4,0,0,5,4,0,4,0,4,0,4,0,12
	.byte 0,4,5,4,5,4,0,4,0,4,0,4,1,4,0,16,0,4,0,4,0,0,0,8,0,20,5,4,0,4,0,4
	.byte 0,4,1,8,0,0,5,4,0,4,0,4,0,4,0,4,0,12,0,4,5,4,5,4,0,4,0,4,0,4,1,12
	.byte 0,20,0,4,0,4,0,0,0,4,5,4,0,4,0,4,0,4,0,4,0,4,0,16,0,4,0,4,0,4,0,4
	.byte 0,4,5,4,0,16,1,4,0,16,0,4,5,4,1,32,10,128,206,1,42,1,88,0,0,2,64,0,1,2,2,32
	.byte 0,1,3,20,72,0,1,4,10,64,1,1,5,2,48,0,1,6,10,80,1,1,7,12,56,0,0,0,48,2,0,51
	.byte 129,36,60,129,52,208,0,0,29,24,25,0,19,0,60,1,32,0,16,0,12,10,8,0,16,0,16,6,24,0,28,0
	.byte 0,0,0,0,0,0,4,0,8,5,24,6,4,0,20,1,4,1,16,10,0,1,32,1,64,0,0,2,64,0,1,2
	.byte 2,32,0,1,3,20,72,0,1,4,10,64,0,1,5,10,56,0,0,0,32,2,0,31,128,208,48,128,220,0,12,0
	.byte 48,1,32,0,16,0,12,10,8,0,16,5,16,0,24,0,0,0,0,5,4,1,32,10,128,223,1,37,1,80,0,0
	.byte 2,64,0,1,2,2,32,0,1,3,20,72,0,1,4,10,64,1,1,5,4,64,0,1,6,10,72,0,0,0,32,2
	.byte 0,47,129,0,56,129,12,208,0,0,29,16,208,0,0,29,24,0,15,0,56,1,32,0,16,0,12,10,8,0,16,0
	.byte 16,7,32,0,32,0,0,0,0,0,0,0,0,5,4,1,32,10,128,237,1,249,1,1,232,1,0,0,2,64,0,1
	.byte 2,2,32,0,2,3,5,12,48,0,1,4,10,88,0,0,12,88,0,2,6,8,12,48,0,1,7,10,88,0,0,12
	.byte 88,0,2,9,11,12,48,0,1,10,10,88,0,0,12,88,0,2,12,14,14,48,0,1,13,10,88,0,0,12,88,0
	.byte 2,15,17,14,48,0,1,16,10,88,0,0,12,88,0,1,18,2,40,0,1,19,10,56,1,1,20,2,48,0,1,21
	.byte 2,40,0,1,22,10,56,1,1,23,2,48,0,1,24,4,40,0,1,25,10,56,1,1,26,2,48,0,1,27,4,48
	.byte 0,1,28,10,56,1,1,29,2,48,0,1,30,20,72,0,1,31,10,64,1,1,32,2,40,0,1,33,10,64,1,1
	.byte 34,12,104,0,1,35,10,64,1,1,36,2,48,0,1,37,10,128,1,0,1,38,10,80,1,1,39,4,48,0,1,40
	.byte 2,48,0,1,41,10,48,0,1,42,2,48,0,1,43,10,48,0,1,44,2,48,0,1,45,10,48,0,1,46,2,48
	.byte 0,1,47,10,48,0,1,48,18,48,0,0,0,40,2,0,129,145,134,88,128,132,134,116,20,21,208,0,0,29,64,23
	.byte 24,25,208,0,0,29,72,19,208,0,0,29,104,208,0,0,29,112,208,0,0,29,120,208,0,0,29,128,128,208,0,0
	.byte 29,128,136,0,128,174,0,128,132,1,32,0,16,1,4,0,0,5,4,0,16,0,12,0,4,0,0,0,4,5,8,0
	.byte 20,0,8,0,8,0,0,5,4,0,4,1,0,0,16,1,4,0,0,5,4,0,16,0,12,0,4,0,0,0,4,5
	.byte 8,0,20,0,8,0,8,0,0,5,4,0,4,1,0,0,16,1,4,0,0,5,4,0,16,0,12,0,4,0,0,0
	.byte 4,5,8,0,20,0,8,0,8,0,0,5,4,0,4,1,0,0,16,2,4,0,0,5,4,0,16,0,12,0,4,0
	.byte 0,0,4,5,8,0,20,0,8,0,8,0,0,5,4,0,4,1,0,0,16,2,4,0,0,5,4,0,16,0,12,0
	.byte 4,0,0,0,4,5,8,0,20,0,8,0,8,0,0,5,4,0,4,1,0,0,16,1,4,0,16,0,4,0,8,5
	.byte 20,1,4,0,16,1,4,0,16,0,4,0,8,5,20,1,4,0,16,2,4,0,16,0,4,0,8,5,20,1,4,2
	.byte 24,0,20,0,0,0,8,5,20,1,4,0,16,0,12,10,8,0,16,0,16,5,16,1,4,0,16,0,4,0,4,0
	.byte 0,0,8,5,16,4,32,2,4,0,16,0,4,0,4,0,0,0,8,6,24,0,52,0,0,0,0,0,0,0,0,0
	.byte 0,0,0,0,0,0,0,0,4,5,8,0,20,0,12,0,0,0,0,0,8,5,20,2,4,0,16,1,8,0,20,0
	.byte 0,5,4,1,24,0,20,0,0,5,4,1,24,0,20,0,0,5,4,1,24,0,20,0,0,5,4,2,20,7,4,2
	.byte 20,1,16,10,129,12,1,201,2,1,136,2,0,0,2,64,0,1,2,2,32,0,2,3,5,12,48,0,1,4,10,88
	.byte 0,0,12,88,0,2,6,8,12,48,0,1,7,10,88,0,0,12,88,0,2,9,11,12,48,0,1,10,10,88,0,0
	.byte 12,88,0,2,12,14,14,48,0,1,13,10,88,0,0,12,88,0,2,15,17,14,48,0,1,16,10,88,0,0,12,88
	.byte 0,2,18,20,14,48,0,1,19,10,88,0,0,12,88,0,2,21,23,14,48,0,1,22,10,88,0,0,12,88,0,2
	.byte 24,26,14,48,0,1,25,10,88,0,0,12,88,0,1,27,2,40,0,1,28,10,56,1,1,29,2,48,0,1,30,2
	.byte 48,0,1,31,10,56,1,1,32,2,48,0,1,33,4,48,0,1,34,10,56,1,1,35,2,48,0,1,36,4,48,0
	.byte 1,37,10,56,1,1,38,2,48,0,1,39,4,48,0,1,40,10,56,1,1,41,4,48,0,1,42,20,72,0,1,43
	.byte 10,64,1,1,44,2,48,0,1,45,10,72,1,1,46,12,112,0,1,47,10,72,1,1,48,6,64,0,1,49,10,72
	.byte 1,1,50,8,64,0,1,51,10,176,1,0,1,52,10,80,1,1,53,4,48,0,1,54,2,48,0,1,55,10,48,0
	.byte 1,56,2,48,0,1,57,10,48,0,1,58,2,48,0,1,59,10,48,0,1,60,2,48,0,1,61,10,48,0,1,62
	.byte 4,48,0,1,63,10,48,0,1,64,18,48,0,0,0,48,2,0,130,39,136,180,128,148,136,212,208,0,0,29,88,25
	.byte 208,0,0,29,96,208,0,0,29,104,208,0,0,29,112,208,0,0,29,120,208,0,0,29,128,128,208,0,0,29,128,136
	.byte 208,0,0,28,0,208,0,0,28,8,24,22,19,26,23,21,20,0,128,243,0,128,148,1,32,1,20,0,0,5,4,0
	.byte 16,0,12,0,4,0,0,0,4,5,8,0,20,0,8,0,8,0,0,5,4,0,4,1,0,0,16,1,4,0,0,5
	.byte 4,0,16,0,12,0,4,0,0,0,4,5,8,0,20,0,8,0,8,0,0,5,4,0,4,1,0,1,20,0,0,5
	.byte 4,0,16,0,12,0,4,0,0,0,4,5,8,0,20,0,8,0,8,0,0,5,4,0,4,1,0,2,20,0,0,5
	.byte 4,0,16,0,12,0,4,0,0,0,4,5,8,0,20,0,8,0,8,0,0,5,4,0,4,1,0,2,20,0,0,5
	.byte 4,0,16,0,12,0,4,0,0,0,4,5,8,0,20,0,8,0,8,0,0,5,4,0,4,1,0,2,20,0,0,5
	.byte 4,0,16,0,12,0,4,0,0,0,4,5,8,0,20,0,8,0,8,0,0,5,4,0,4,1,0,2,20,0,0,5
	.byte 4,0,16,0,12,0,4,0,0,0,4,5,8,0,20,0,8,0,8,0,0,5,4,0,4,1,0,2,20,0,0,5
	.byte 4,0,16,0,12,0,4,0,0,0,4,5,8,0,20,0,8,0,8,0,0,5,4,0,4,1,0,0,16,1,4,0
	.byte 16,0,4,0,8,5,20,1,4,1,24,0,20,0,0,0,8,5,20,1,4,2,24,0,20,0,0,0,8,5,20,1
	.byte 4,2,24,0,20,0,0,0,8,5,20,1,4,2,24,0,20,0,0,0,8,5,20,2,4,0,16,0,12,10,8,0
	.byte 16,0,16,6,24,0,20,0,4,0,4,0,0,0,8,5,16,2,16,1,8,3,16,0,20,0,4,0,4,0,0,0
	.byte 8,5,16,3,16,0,20,0,4,0,4,0,0,0,8,7,24,2,8,0,64,0,0,0,0,0,0,0,0,0,0,0
	.byte 0,0,0,0,0,0,4,0,4,0,4,0,4,5,8,0,20,0,12,0,0,0,0,0,8,5,20,2,4,0,16,1
	.byte 8,0,20,0,0,5,4,0,16,1,8,0,20,0,0,5,4,0,16,1,8,0,20,0,0,5,4,0,16,1,8,0
	.byte 20,0,0,5,4,0,16,2,8,0,20,0,0,5,4,0,16,2,4,7,4,0,16,2,4,1,20,10,85,1,57,1
	.byte 80,0,0,2,64,0,1,2,2,32,0,2,3,5,12,48,0,1,4,10,88,0,0,12,88,0,1,6,20,72,0,1
	.byte 7,10,64,1,1,8,2,40,0,1,9,10,64,0,1,10,10,64,0,0,0,32,2,0,82,129,128,56,129,144,26,0
	.byte 37,0,56,1,32,0,16,1,4,0,0,5,4,0,16,0,12,0,4,0,0,0,4,5,8,0,20,0,8,0,8,0
	.byte 0,5,4,0,4,1,0,0,16,0,12,10,8,0,16,0,16,5,16,1,4,0,16,0,4,0,4,0,0,5,8,0
	.byte 28,0,0,0,0,0,0,5,4,1,32,10,0,1,32,1,64,0,0,2,64,0,1,2,2,32,0,1,3,20,72,0
	.byte 1,4,10,64,0,1,5,10,56,0,0,0,32,2,0,31,128,208,48,128,220,0,12,0,48,1,32,0,16,0,12,10
	.byte 8,0,16,5,16,0,24,0,0,0,0,5,4,1,32,10,129,50,1,106,1,136,1,0,0,2,64,0,1,2,2,32
	.byte 0,1,3,2,48,0,1,4,10,56,1,1,5,2,48,0,1,6,20,72,0,1,7,10,64,1,2,8,10,34,168,1
	.byte 0,1,9,10,64,1,1,10,6,104,0,1,11,10,72,1,3,12,14,15,32,184,1,0,1,13,10,72,1,2,14,15
	.byte 34,248,1,0,1,15,10,128,1,0,1,16,10,88,0,1,17,2,40,0,1,18,10,48,0,0,0,32,2,0,129,4
	.byte 131,132,84,131,160,23,208,0,0,29,72,208,0,0,29,80,208,0,0,29,88,22,0,114,0,84,1,32,1,24,0,20
	.byte 0,0,0,8,5,20,1,4,0,16,0,12,10,8,0,16,0,16,5,24,255,255,255,255,241,4,10,4,6,4,0,0
	.byte 5,4,0,4,0,4,0,12,0,4,5,4,5,4,0,4,0,4,1,4,0,16,0,4,0,4,0,0,0,8,0,20
	.byte 5,4,0,4,0,4,0,4,2,12,1,4,0,20,0,0,0,4,0,4,0,8,255,255,255,255,253,20,8,4,0,0
	.byte 5,4,0,4,0,4,0,4,0,4,0,12,0,4,5,4,5,4,0,4,0,4,0,4,1,12,0,20,0,4,0,4
	.byte 0,0,0,8,0,20,5,4,0,4,0,4,0,4,0,4,1,8,0,0,5,4,0,4,0,4,0,4,0,4,0,4
	.byte 0,12,0,4,5,4,5,4,0,4,0,4,0,4,0,4,1,12,0,20,0,4,0,4,0,0,0,4,5,4,0,4
	.byte 0,4,0,4,0,4,0,12,0,20,0,4,0,4,0,4,0,4,0,4,0,0,5,4,0,16,1,4,0,16,0,4
	.byte 5,4,1,32,10,129,50,1,106,1,136,1,0,0,2,64,0,1,2,2,32,0,1,3,2,48,0,1,4,10,56,1
	.byte 1,5,2,48,0,1,6,20,72,0,1,7,10,64,1,2,8,10,34,168,1,0,1,9,10,64,1,1,10,6,104,0
	.byte 1,11,10,72,1,3,12,14,15,32,184,1,0,1,13,10,72,1,2,14,15,34,248,1,0,1,15,10,128,1,0,1
	.byte 16,10,88,0,1,17,2,40,0,1,18,10,48,0,0,0,32,2,0,129,4,131,132,84,131,160,23,208,0,0,29,72
	.byte 208,0,0,29,80,208,0,0,29,88,22,0,114,0,84,1,32,1,24,0,20,0,0,0,8,5,20,1,4,0,16,0
	.byte 12,10,8,0,16,0,16,5,24,255,255,255,255,241,4,10,4,6,4,0,0,5,4,0,4,0,4,0,12,0,4,5
	.byte 4,5,4,0,4,0,4,1,4,0,16,0,4,0,4,0,0,0,8,0,20,5,4,0,4,0,4,0,4,2,12,1
	.byte 4,0,20,0,0,0,4,0,4,0,8,255,255,255,255,253,20,8,4,0,0,5,4,0,4,0,4,0,4,0,4,0
	.byte 12,0,4,5,4,5,4,0,4,0,4,0,4,1,12,0,20,0,4,0,4,0,0,0,8,0,20,5,4,0,4,0
	.byte 4,0,4,0,4,1,8,0,0,5,4,0,4,0,4,0,4,0,4,0,4,0,12,0,4,5,4,5,4,0,4,0
	.byte 4,0,4,0,4,1,12,0,20,0,4,0,4,0,0,0,4,5,4,0,4,0,4,0,4,0,4,0,12,0,20,0
	.byte 4,0,4,0,4,0,4,0,4,0,0,5,4,0,16,1,4,0,16,0,4,5,4,1,32,10,129,83,1,79,1,120
	.byte 0,0,2,64,0,1,2,2,32,0,1,3,20,72,0,1,4,10,64,1,2,5,7,34,168,1,0,1,6,10,64,1
	.byte 1,7,4,88,0,1,8,10,72,1,3,9,11,12,32,152,1,0,1,10,10,64,1,2,11,12,34,216,1,0,1,12
	.byte 10,104,0,1,13,10,80,0,0,0,32,2,0,128,212,130,200,76,130,228,24,25,26,0,99,0,76,1,32,0,16,0
	.byte 12,10,8,0,16,0,16,5,24,255,255,255,255,241,4,10,4,6,4,0,0,5,4,0,4,0,4,0,12,0,4,5
	.byte 4,5,4,0,4,0,4,1,4,0,16,0,4,0,4,0,0,0,8,0,20,5,4,0,4,0,4,0,4,1,4,1
	.byte 4,0,16,0,4,0,4,0,4,0,8,5,20,0,0,5,4,0,4,0,4,0,4,0,12,0,4,5,4,5,4,0
	.byte 4,0,4,0,4,1,4,0,16,0,4,0,4,0,0,0,8,0,20,5,4,0,4,0,4,0,4,0,4,1,4,0
	.byte 0,5,4,0,4,0,4,0,4,0,4,0,12,0,4,5,4,5,4,0,4,0,4,0,4,0,4,1,4,0,16,0
	.byte 4,0,4,0,0,0,4,5,4,0,4,0,4,0,4,0,4,0,4,0,16,0,4,0,4,0,4,0,4,0,4,5
	.byte 4,1,32,10,129,118,1,44,1,88,0,0,2,64,0,1,2,2,32,0,1,3,20,72,0,1,4,10,64,1,2,5
	.byte 6,34,168,1,0,1,6,10,88,0,1,7,10,64,0,0,0,32,2,0,86,129,96,60,129,116,26,0,37,0,60,1
	.byte 32,0,16,0,12,10,8,0,16,0,16,5,24,255,255,255,255,241,4,10,4,6,4,0,0,5,4,0,4,0,4,0
	.byte 12,0,4,5,4,5,4,0,4,0,4,1,4,0,16,0,4,0,4,0,0,0,4,5,4,0,4,0,4,0,4,0
	.byte 16,0,4,0,4,0,4,5,4,1,32,10,129,142,1,102,1,104,0,0,2,64,0,1,2,2,32,0,2,3,5,12
	.byte 48,0,1,4,10,88,0,0,12,88,0,2,6,8,12,48,0,1,7,10,88,0,0,12,88,0,1,9,2,40,0,1
	.byte 10,10,56,1,1,11,2,48,0,1,12,20,72,0,1,13,10,64,1,1,14,2,40,0,1,15,10,64,1,1,16,2
	.byte 48,0,1,17,10,72,0,1,18,2,48,0,1,19,10,48,0,0,0,32,2,0,128,148,130,144,68,130,164,25,26,24
	.byte 0,69,0,68,1,32,0,16,1,4,0,0,5,4,0,16,0,12,0,4,0,0,0,4,5,8,0,20,0,8,0,8
	.byte 0,0,5,4,0,4,1,0,0,16,1,4,0,0,5,4,0,16,0,12,0,4,0,0,0,4,5,8,0,20,0,8
	.byte 0,8,0,0,5,4,0,4,1,0,0,16,1,4,0,16,0,4,0,8,5,20,1,4,0,16,0,12,10,8,0,16
	.byte 0,16,5,16,1,4,0,16,0,4,0,4,0,0,0,8,5,16,1,8,0,32,0,0,0,0,0,0,0,0,5,4
	.byte 0,16,1,8,0,20,0,0,5,4,1,32,10,102,1,77,1,88,0,0,2,64,0,1,2,2,32,0,2,3,5,12
	.byte 48,0,1,4,10,88,0,0,12,88,0,1,6,2,40,0,1,7,10,56,1,1,8,2,56,0,1,9,20,72,0,1
	.byte 10,10,64,1,1,11,2,48,0,1,12,10,64,0,1,13,2,48,0,1,14,10,48,0,0,0,32,2,0,97,129,228
	.byte 60,129,244,26,25,0,44,0,60,1,32,0,16,1,4,0,0,5,4,0,16,0,12,0,4,0,0,0,4,5,8,0
	.byte 20,0,8,0,8,0,0,5,4,0,4,1,0,0,16,1,4,0,16,0,4,0,8,5,24,1,4,0,16,0,12,10
	.byte 8,0,16,0,16,5,24,1,0,0,28,0,0,0,0,0,0,5,4,0,16,1,8,0,20,0,0,5,4,1,32,10
	.byte 102,1,77,1,88,0,0,2,64,0,1,2,2,32,0,2,3,5,12,48,0,1,4,10,88,0,0,12,88,0,1,6
	.byte 2,40,0,1,7,10,56,1,1,8,2,56,0,1,9,20,72,0,1,10,10,64,1,1,11,2,48,0,1,12,10,64
	.byte 0,1,13,2,48,0,1,14,10,48,0,0,0,32,2,0,97,129,228,60,129,244,26,25,0,44,0,60,1,32,0,16
	.byte 1,4,0,0,5,4,0,16,0,12,0,4,0,0,0,4,5,8,0,20,0,8,0,8,0,0,5,4,0,4,1,0
	.byte 0,16,1,4,0,16,0,4,0,8,5,24,1,4,0,16,0,12,10,8,0,16,0,16,5,24,1,0,0,28,0,0
	.byte 0,0,0,0,5,4,0,16,1,8,0,20,0,0,5,4,1,32,10,14,1,42,1,80,0,0,2,64,0,1,2,2
	.byte 32,0,1,3,20,72,0,1,4,10,64,0,1,5,10,64,0,1,6,10,56,1,1,7,12,56,0,0,0,48,2,0
	.byte 46,129,28,56,129,44,26,0,19,0,56,1,32,0,16,0,12,10,8,0,16,5,16,0,24,0,0,0,0,5,8,0
	.byte 20,0,0,0,8,5,24,6,4,0,20,1,4,1,16,10,0,1,17,1,64,0,0,2,64,0,1,2,20,72,1,0
	.byte 0,72,2,0,23,128,152,48,128,164,0,8,0,48,0,32,5,12,0,0,0,8,5,20,0,12,6,20,10,129,164,1
	.byte 45,1,136,2,0,0,2,64,0,1,2,4,40,0,1,3,28,64,0,2,4,6,16,72,0,1,5,4,32,0,1,6
	.byte 28,144,1,0,1,7,2,96,0,0,0,40,2,0,102,129,168,128,148,129,188,208,0,0,29,16,208,0,0,29,24,208
	.byte 0,0,29,128,176,208,0,0,29,128,184,208,0,0,29,128,192,23,0,32,0,128,148,0,32,2,4,8,24,0,0,0
	.byte 0,5,4,1,4,0,16,2,12,1,4,0,0,5,4,2,16,0,16,6,4,0,4,0,4,0,4,1,4,0,0,5
	.byte 4,0,4,0,8,1,0,1,4,0,32,1,4,0,8,0,4,0,32,1,20,10,129,164,1,45,1,136,2,0,0,2
	.byte 64,0,1,2,4,40,0,1,3,28,64,0,2,4,6,16,72,0,1,5,4,32,0,1,6,28,144,1,0,1,7,2
	.byte 96,0,0,0,40,2,0,102,129,168,128,148,129,188,208,0,0,29,16,208,0,0,29,24,208,0,0,29,128,176,208,0
	.byte 0,29,128,184,208,0,0,29,128,192,23,0,32,0,128,148,0,32,2,4,8,24,0,0,0,0,5,4,1,4,0,16
	.byte 2,12,1,4,0,0,5,4,2,16,0,16,6,4,0,4,0,4,0,4,1,4,0,0,5,4,0,4,0,8,1,0
	.byte 1,4,0,32,1,4,0,8,0,4,0,32,1,20,10,129,204,1,45,1,144,2,0,0,2,64,0,1,2,4,40,0
	.byte 1,3,30,72,0,2,4,6,16,72,0,1,5,4,32,0,1,6,28,144,1,0,1,7,2,96,0,0,0,40,2,0
	.byte 109,129,176,128,152,129,196,208,0,0,29,16,208,0,0,29,24,208,0,0,29,32,208,0,0,29,128,184,208,0,0,29
	.byte 128,192,208,0,0,29,128,200,22,0,33,0,128,152,0,32,2,4,9,28,0,0,0,0,0,0,5,4,1,4,0,16
	.byte 2,12,1,4,0,0,5,4,2,16,0,16,6,4,0,4,0,4,0,4,1,4,0,0,5,4,0,4,0,8,1,0
	.byte 1,4,0,32,1,4,0,8,0,4,0,32,1,20,10,129,204,1,40,1,136,2,0,0,2,64,0,1,2,4,40,0
	.byte 1,3,28,64,0,2,4,6,16,72,0,1,5,4,32,0,1,6,28,144,1,0,0,0,56,2,0,100,129,128,128,148
	.byte 129,148,208,0,0,29,16,208,0,0,29,24,208,0,0,29,32,208,0,0,29,128,184,208,0,0,29,128,192,208,0,0
	.byte 29,128,200,0,29,0,128,148,0,32,2,4,9,28,0,0,0,0,0,0,5,4,0,16,2,12,1,4,0,0,5,4
	.byte 2,16,0,16,6,4,0,4,0,4,0,4,1,4,0,0,5,4,0,4,0,8,1,0,1,4,0,32,0,8,1,20
	.byte 10,129,244,1,40,1,144,2,0,0,2,64,0,1,2,4,40,0,1,3,30,72,0,2,4,6,16,72,0,1,5,4
	.byte 32,0,1,6,28,144,1,0,0,0,56,2,0,107,129,136,128,152,129,156,208,0,0,29,16,208,0,0,29,24,208,0
	.byte 0,29,32,208,0,0,29,40,208,0,0,29,128,192,208,0,0,29,128,200,208,0,0,29,128,208,0,30,0,128,152,0
	.byte 32,2,4,10,32,0,0,0,0,0,0,0,0,5,4,0,16,2,12,1,4,0,0,5,4,2,16,0,16,6,4,0
	.byte 4,0,4,0,4,1,4,0,0,5,4,0,4,0,8,1,0,1,4,0,32,0,8,1,20,10,130,28,1,40,1,160
	.byte 2,0,0,2,64,0,1,2,4,40,0,1,3,38,88,0,2,4,6,16,72,0,1,5,4,32,0,1,6,28,136,1
	.byte 0,0,0,56,2,0,113,129,148,128,160,129,164,208,0,0,29,16,208,0,0,29,24,208,0,0,29,32,208,0,0,29
	.byte 40,208,0,0,29,48,208,0,0,29,56,208,0,0,29,128,208,208,0,0,29,128,216,208,0,0,29,128,224,0,28,0
	.byte 128,160,0,32,2,4,14,40,0,0,0,0,0,0,0,0,0,0,0,0,5,4,0,16,2,12,1,4,0,0,5,4
	.byte 2,16,0,16,6,4,0,12,1,4,0,0,5,8,0,4,2,4,0,32,0,8,1,20,10,130,68,1,40,1,152,2
	.byte 0,0,2,64,0,1,2,4,40,0,1,3,34,80,0,2,4,6,16,72,0,1,5,4,32,0,1,6,28,136,1,0
	.byte 0,0,56,2,0,110,129,140,128,156,129,156,208,0,0,29,16,208,0,0,29,24,208,0,0,29,32,208,0,0,29,40
	.byte 208,0,0,29,48,208,0,0,29,128,200,208,0,0,29,128,208,208,0,0,29,128,216,0,29,0,128,156,0,32,2,4
	.byte 12,36,0,0,0,0,0,0,0,0,0,0,5,4,0,16,2,12,1,4,0,0,5,4,2,16,0,16,6,4,0,4
	.byte 0,4,0,4,1,4,0,0,5,8,0,4,2,4,0,32,0,8,1,20,10,129,244,1,40,1,144,2,0,0,2,64
	.byte 0,1,2,4,40,0,1,3,30,72,0,2,4,6,16,72,0,1,5,4,32,0,1,6,28,144,1,0,0,0,56,2
	.byte 0,107,129,136,128,152,129,156,208,0,0,29,16,208,0,0,29,24,208,0,0,29,32,208,0,0,29,40,208,0,0,29
	.byte 128,192,208,0,0,29,128,200,208,0,0,29,128,208,0,30,0,128,152,0,32,2,4,10,32,0,0,0,0,0,0,0
	.byte 0,5,4,0,16,2,12,1,4,0,0,5,4,2,16,0,16,6,4,0,4,0,4,0,4,1,4,0,0,5,4,0
	.byte 4,0,8,1,0,1,4,0,32,0,8,1,20,10,129,164,1,40,1,128,2,0,0,2,64,0,1,2,4,40,0,1
	.byte 3,26,56,0,2,4,6,16,72,0,1,5,4,32,0,1,6,28,144,1,0,0,0,56,2,0,93,129,120,128,144,129
	.byte 140,208,0,0,29,16,208,0,0,29,24,208,0,0,29,128,176,208,0,0,29,128,184,208,0,0,29,128,192,0,28,0
	.byte 128,144,0,32,2,4,8,24,0,0,0,0,5,4,0,16,2,12,1,4,0,0,5,4,2,16,0,16,6,4,0,4
	.byte 0,4,0,4,1,4,0,0,5,4,0,4,0,8,1,0,1,4,0,32,0,8,1,20,10,129,244,1,40,1,144,2
	.byte 0,0,2,64,0,1,2,4,40,0,1,3,30,72,0,2,4,6,16,72,0,1,5,4,32,0,1,6,28,144,1,0
	.byte 0,0,56,2,0,107,129,136,128,152,129,156,208,0,0,29,16,208,0,0,29,24,208,0,0,29,32,208,0,0,29,40
	.byte 208,0,0,29,128,192,208,0,0,29,128,200,208,0,0,29,128,208,0,30,0,128,152,0,32,2,4,10,32,0,0,0
	.byte 0,0,0,0,0,5,4,0,16,2,12,1,4,0,0,5,4,2,16,0,16,6,4,0,4,0,4,0,4,1,4,0
	.byte 0,5,4,0,4,0,8,1,0,1,4,0,32,0,8,1,20,10,130,108,1,46,1,224,2,0,0,2,64,0,1,2
	.byte 4,40,0,1,3,52,128,1,0,2,4,6,16,72,0,1,5,4,32,0,1,6,28,144,1,0,1,7,2,96,0,0
	.byte 0,40,2,0,128,151,129,244,128,192,130,12,208,0,0,29,16,208,0,0,29,24,208,0,0,29,32,208,0,0,29,40
	.byte 208,0,0,29,48,208,0,0,29,56,208,0,0,29,64,208,0,0,29,72,208,0,0,28,0,208,0,0,29,128,224,208
	.byte 0,0,29,128,232,208,0,0,29,128,240,25,0,39,0,128,192,0,32,2,4,20,52,0,0,0,0,0,0,0,0,0
	.byte 0,0,0,0,0,0,0,0,4,5,4,1,4,0,16,2,12,1,4,0,0,5,4,2,16,0,16,6,4,0,4,0
	.byte 4,0,4,1,4,0,0,5,4,0,4,0,8,1,0,1,4,0,32,1,4,0,8,0,4,0,32,1,20,10,130,108
	.byte 1,57,1,232,2,0,0,2,64,0,1,2,4,40,0,2,3,4,14,48,0,1,4,6,72,0,1,5,64,176,1,0
	.byte 2,6,8,16,72,0,1,7,4,32,0,1,8,28,144,1,0,1,9,2,96,0,0,0,40,2,0,128,185,130,76,128
	.byte 196,130,104,208,0,0,29,16,208,0,0,29,24,208,0,0,29,32,208,0,0,29,40,208,0,0,29,48,208,0,0,29
	.byte 56,208,0,0,29,64,208,0,0,29,72,208,0,0,28,0,208,0,0,28,8,208,0,0,28,16,208,0,0,28,24,208
	.byte 0,0,29,128,224,208,0,0,29,128,232,208,0,0,29,128,240,24,23,0,48,0,128,196,0,32,2,4,2,20,0,0
	.byte 5,4,0,16,3,4,16,72,10,8,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,4,0,4
	.byte 0,4,5,4,1,4,0,16,2,12,1,4,0,0,5,4,2,16,0,16,6,4,0,4,0,4,0,4,1,4,0,0
	.byte 5,4,0,4,0,8,1,0,1,4,0,32,1,4,0,8,0,4,0,32,1,20,10,129,244,1,40,1,144,2,0,0
	.byte 2,64,0,1,2,4,40,0,1,3,30,72,0,2,4,6,16,72,0,1,5,4,32,0,1,6,28,144,1,0,0,0
	.byte 56,2,0,107,129,136,128,152,129,156,208,0,0,29,16,208,0,0,29,24,208,0,0,29,32,208,0,0,29,40,208,0
	.byte 0,29,128,192,208,0,0,29,128,200,208,0,0,29,128,208,0,30,0,128,152,0,32,2,4,10,32,0,0,0,0,0
	.byte 0,0,0,5,4,0,16,2,12,1,4,0,0,5,4,2,16,0,16,6,4,0,4,0,4,0,4,1,4,0,0,5
	.byte 4,0,4,0,8,1,0,1,4,0,32,0,8,1,20,10,129,204,1,45,1,144,2,0,0,2,64,0,1,2,4,40
	.byte 0,1,3,30,80,0,2,4,6,16,72,0,1,5,4,32,0,1,6,28,144,1,0,1,7,2,96,0,0,0,40,2
	.byte 0,111,129,180,128,152,129,200,208,0,0,29,16,208,0,0,29,24,208,0,0,29,32,208,0,0,29,128,184,208,0,0
	.byte 29,128,192,208,0,0,29,128,200,22,0,34,0,128,152,0,32,2,4,9,28,0,0,0,0,0,0,0,4,5,4,1
	.byte 4,0,16,2,12,1,4,0,0,5,4,2,16,0,16,6,4,0,4,0,4,0,4,1,4,0,0,5,4,0,4,0
	.byte 8,1,0,1,4,0,32,1,4,0,8,0,4,0,32,1,20,0,128,144,16,0,0,1,4,128,196,15,16,8,0,1
	.byte 194,0,33,110,194,0,33,107,194,0,33,106,194,0,33,104,45,128,134,47,193,0,6,18,40,8,0,8,193,0,6,46
	.byte 193,0,6,43,193,0,6,18,193,0,6,44,193,0,6,45,193,0,6,36,193,0,6,19,193,0,6,52,193,0,6,53
	.byte 193,0,6,56,193,0,6,57,193,0,6,58,193,0,6,54,193,0,6,55,193,0,6,29,193,0,6,59,193,0,6,33
	.byte 193,0,6,30,193,0,6,34,193,0,6,62,193,0,6,66,193,0,6,61,193,0,6,65,193,0,6,63,193,0,6,64
	.byte 193,0,6,67,193,0,6,67,193,0,6,66,193,0,6,65,193,0,6,64,193,0,6,63,193,0,6,62,193,0,6,61
	.byte 193,0,6,60,193,0,6,59,193,0,6,58,193,0,6,57,193,0,6,56,193,0,6,55,193,0,6,54,193,0,6,53
	.byte 193,0,6,52,19,193,0,6,48,193,0,6,29,115,103,101,110,0
.section	__DATA,__objc_selrefs,literal_pointers,no_dead_strip
.align	3
L_OBJC_SELECTOR_REFERENCES_0:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_0
L_OBJC_SELECTOR_REFERENCES_1:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_1
L_OBJC_SELECTOR_REFERENCES_2:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_2
L_OBJC_SELECTOR_REFERENCES_3:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_3
L_OBJC_SELECTOR_REFERENCES_4:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_4
L_OBJC_SELECTOR_REFERENCES_5:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_5
L_OBJC_SELECTOR_REFERENCES_6:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_6
L_OBJC_SELECTOR_REFERENCES_7:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_7
L_OBJC_SELECTOR_REFERENCES_8:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_8
L_OBJC_SELECTOR_REFERENCES_9:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_9
L_OBJC_SELECTOR_REFERENCES_10:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_10
L_OBJC_SELECTOR_REFERENCES_11:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_11
L_OBJC_SELECTOR_REFERENCES_12:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_12
L_OBJC_SELECTOR_REFERENCES_13:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_13
L_OBJC_SELECTOR_REFERENCES_14:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_14
L_OBJC_SELECTOR_REFERENCES_15:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_15
L_OBJC_SELECTOR_REFERENCES_16:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_16
L_OBJC_SELECTOR_REFERENCES_17:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_17
L_OBJC_SELECTOR_REFERENCES_18:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_18
L_OBJC_SELECTOR_REFERENCES_19:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_19
L_OBJC_SELECTOR_REFERENCES_20:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_20
L_OBJC_SELECTOR_REFERENCES_21:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_21
L_OBJC_SELECTOR_REFERENCES_22:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_22
L_OBJC_SELECTOR_REFERENCES_23:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_23
L_OBJC_SELECTOR_REFERENCES_24:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_24
L_OBJC_SELECTOR_REFERENCES_25:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_25
L_OBJC_SELECTOR_REFERENCES_26:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_26
L_OBJC_SELECTOR_REFERENCES_27:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_27
.section	__TEXT,__cstring,cstring_literals
L_OBJC_METH_VAR_NAME_0:
.asciz "init"
L_OBJC_METH_VAR_NAME_1:
.asciz "beginLogPageView:duration:"
L_OBJC_METH_VAR_NAME_2:
.asciz "clearAllLocalNotifications"
L_OBJC_METH_VAR_NAME_3:
.asciz "crashLogON"
L_OBJC_METH_VAR_NAME_4:
.asciz "deleteLocalNotification:"
L_OBJC_METH_VAR_NAME_5:
.asciz "deleteLocalNotificationWithIdentifierKey:"
L_OBJC_METH_VAR_NAME_6:
.asciz "filterValidTags:"
L_OBJC_METH_VAR_NAME_7:
.asciz "findLocalNotificationWithIdentifier:"
L_OBJC_METH_VAR_NAME_8:
.asciz "handleRemoteNotification:"
L_OBJC_METH_VAR_NAME_9:
.asciz "registerDeviceToken:"
L_OBJC_METH_VAR_NAME_10:
.asciz "registerForRemoteNotificationTypes:categories:"
L_OBJC_METH_VAR_NAME_11:
.asciz "resetBadge"
L_OBJC_METH_VAR_NAME_12:
.asciz "setAlias:callbackSelector:object:"
L_OBJC_METH_VAR_NAME_13:
.asciz "setBadge:"
L_OBJC_METH_VAR_NAME_14:
.asciz "setDebugMode"
L_OBJC_METH_VAR_NAME_15:
.asciz "setLatitude:longitude:"
L_OBJC_METH_VAR_NAME_16:
.asciz "setLocalNotification:alertBody:badge:alertAction:identifierKey:userInfo:soundName:"
L_OBJC_METH_VAR_NAME_17:
.asciz "setLocalNotification:alertBody:badge:alertAction:identifierKey:userInfo:soundName:region:regionTriggersOnce:category:"
L_OBJC_METH_VAR_NAME_18:
.asciz "setLocation:"
L_OBJC_METH_VAR_NAME_19:
.asciz "setLogOFF"
L_OBJC_METH_VAR_NAME_20:
.asciz "setTags:alias:callbackSelector:object:"
L_OBJC_METH_VAR_NAME_21:
.asciz "setTags:alias:callbackSelector:target:"
L_OBJC_METH_VAR_NAME_22:
.asciz "setTags:callbackSelector:object:"
L_OBJC_METH_VAR_NAME_23:
.asciz "setupWithOption:"
L_OBJC_METH_VAR_NAME_24:
.asciz "showLocalNotificationAtFront:identifierKey:"
L_OBJC_METH_VAR_NAME_25:
.asciz "startLogPageView:"
L_OBJC_METH_VAR_NAME_26:
.asciz "stopLogPageView:"
L_OBJC_METH_VAR_NAME_27:
.asciz "registrationID"
.section	__DATA,__objc_imageinfo,regular,no_dead_strip
.align	3
L_OBJC_IMAGE_INFO:
.long	0
.long	16
.section __TEXT, __const
	.align 3
Lglobals_hash:

	.short 11, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0
.data
	.align 3
globals:
	.align 3
	.quad Lglobals_hash

	.long 0,0
.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "ApiDefinition.Messaging:.cctor"
	.asciz "ApiDefinition_Messaging__cctor"

	.byte 1,38
	.quad ApiDefinition_Messaging__cctor
	.quad Lme_e

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM3=Lfde0_end - Lfde0_start
	.long LDIFF_SYM3
Lfde0_start:

	.long 0
	.align 3
	.quad ApiDefinition_Messaging__cctor

LDIFF_SYM4=Lme_e - ApiDefinition_Messaging__cctor
	.long LDIFF_SYM4
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29
	.align 3
Lfde0_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_2:

	.byte 17
	.asciz "System_Object"

	.byte 16,7
	.asciz "System_Object"

LDIFF_SYM5=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM5
LTDIE_2_POINTER:

	.byte 13
LDIFF_SYM6=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM6
LTDIE_2_REFERENCE:

	.byte 14
LDIFF_SYM7=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM7
LTDIE_3:

	.byte 8
	.asciz "_Flags"

	.byte 1
LDIFF_SYM8=LDIE_U1 - Ldebug_info_start
	.long LDIFF_SYM8
	.byte 9
	.asciz "Disposed"

	.byte 1,9
	.asciz "NativeRef"

	.byte 2,9
	.asciz "IsDirectBinding"

	.byte 4,9
	.asciz "RegisteredToggleRef"

	.byte 8,9
	.asciz "InFinalizerQueue"

	.byte 16,0,7
	.asciz "_Flags"

LDIFF_SYM9=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM9
LTDIE_3_POINTER:

	.byte 13
LDIFF_SYM10=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM10
LTDIE_3_REFERENCE:

	.byte 14
LDIFF_SYM11=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM11
LTDIE_1:

	.byte 5
	.asciz "Foundation_NSObject"

	.byte 40,16
LDIFF_SYM12=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM12
	.byte 2,35,0,6
	.asciz "handle"

LDIFF_SYM13=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM13
	.byte 2,35,16,6
	.asciz "class_handle"

LDIFF_SYM14=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM14
	.byte 2,35,24,6
	.asciz "flags"

LDIFF_SYM15=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM15
	.byte 2,35,32,0,7
	.asciz "Foundation_NSObject"

LDIFF_SYM16=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM16
LTDIE_1_POINTER:

	.byte 13
LDIFF_SYM17=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM17
LTDIE_1_REFERENCE:

	.byte 14
LDIFF_SYM18=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM18
LTDIE_0:

	.byte 5
	.asciz "JPush_APService"

	.byte 40,16
LDIFF_SYM19=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM19
	.byte 2,35,0,0,7
	.asciz "JPush_APService"

LDIFF_SYM20=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM20
LTDIE_0_POINTER:

	.byte 13
LDIFF_SYM21=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM21
LTDIE_0_REFERENCE:

	.byte 14
LDIFF_SYM22=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM22
	.byte 2
	.asciz "JPush.APService:.ctor"
	.asciz "JPush_APService__ctor"

	.byte 2,48
	.quad JPush_APService__ctor
	.quad Lme_f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM23=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM23
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM24=Lfde1_end - Lfde1_start
	.long LDIFF_SYM24
Lfde1_start:

	.long 0
	.align 3
	.quad JPush_APService__ctor

LDIFF_SYM25=Lme_f - JPush_APService__ctor
	.long LDIFF_SYM25
	.long 0
	.byte 12,31,0,68,14,96,157,12,158,11,68,13,29,68,154,10
	.align 3
Lfde1_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_4:

	.byte 5
	.asciz "Foundation_NSObjectFlag"

	.byte 16,16
LDIFF_SYM26=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM26
	.byte 2,35,0,0,7
	.asciz "Foundation_NSObjectFlag"

LDIFF_SYM27=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM27
LTDIE_4_POINTER:

	.byte 13
LDIFF_SYM28=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM28
LTDIE_4_REFERENCE:

	.byte 14
LDIFF_SYM29=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM29
	.byte 2
	.asciz "JPush.APService:.ctor"
	.asciz "JPush_APService__ctor_Foundation_NSObjectFlag"

	.byte 2,60
	.quad JPush_APService__ctor_Foundation_NSObjectFlag
	.quad Lme_10

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM30=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM30
	.byte 1,105,3
	.asciz "t"

LDIFF_SYM31=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM31
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM32=Lfde2_end - Lfde2_start
	.long LDIFF_SYM32
Lfde2_start:

	.long 0
	.align 3
	.quad JPush_APService__ctor_Foundation_NSObjectFlag

LDIFF_SYM33=Lme_10 - JPush_APService__ctor_Foundation_NSObjectFlag
	.long LDIFF_SYM33
	.long 0
	.byte 12,31,0,68,14,96,157,12,158,11,68,13,29,68,153,10
	.align 3
Lfde2_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "JPush.APService:.ctor"
	.asciz "JPush_APService__ctor_intptr"

	.byte 2,67
	.quad JPush_APService__ctor_intptr
	.quad Lme_11

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM34=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM34
	.byte 1,105,3
	.asciz "handle"

LDIFF_SYM35=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM35
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM36=Lfde3_end - Lfde3_start
	.long LDIFF_SYM36
Lfde3_start:

	.long 0
	.align 3
	.quad JPush_APService__ctor_intptr

LDIFF_SYM37=Lme_11 - JPush_APService__ctor_intptr
	.long LDIFF_SYM37
	.long 0
	.byte 12,31,0,68,14,96,157,12,158,11,68,13,29,68,153,10
	.align 3
Lfde3_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "JPush.APService:get_ClassHandle"
	.asciz "JPush_APService_get_ClassHandle"

	.byte 2,43
	.quad JPush_APService_get_ClassHandle
	.quad Lme_12

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM38=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM38
	.byte 2,141,24,11
	.asciz ""

LDIFF_SYM39=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM39
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM40=Lfde4_end - Lfde4_start
	.long LDIFF_SYM40
Lfde4_start:

	.long 0
	.align 3
	.quad JPush_APService_get_ClassHandle

LDIFF_SYM41=Lme_12 - JPush_APService_get_ClassHandle
	.long LDIFF_SYM41
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29,68,154,6
	.align 3
Lfde4_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_6:

	.byte 5
	.asciz "System_ValueType"

	.byte 16,16
LDIFF_SYM42=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM42
	.byte 2,35,0,0,7
	.asciz "System_ValueType"

LDIFF_SYM43=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM43
LTDIE_6_POINTER:

	.byte 13
LDIFF_SYM44=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM44
LTDIE_6_REFERENCE:

	.byte 14
LDIFF_SYM45=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM45
LTDIE_5:

	.byte 5
	.asciz "System_Int32"

	.byte 20,16
LDIFF_SYM46=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM46
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM47=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM47
	.byte 2,35,16,0,7
	.asciz "System_Int32"

LDIFF_SYM48=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM48
LTDIE_5_POINTER:

	.byte 13
LDIFF_SYM49=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM49
LTDIE_5_REFERENCE:

	.byte 14
LDIFF_SYM50=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM50
	.byte 2
	.asciz "JPush.APService:BeginLogPageView"
	.asciz "JPush_APService_BeginLogPageView_string_int"

	.byte 2,75
	.quad JPush_APService_BeginLogPageView_string_int
	.quad Lme_13

	.byte 2,118,16,3
	.asciz "pageName"

LDIFF_SYM51=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM51
	.byte 1,105,3
	.asciz "seconds"

LDIFF_SYM52=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM52
	.byte 2,141,32,11
	.asciz "nspageName"

LDIFF_SYM53=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM53
	.byte 1,104,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM54=Lfde5_end - Lfde5_start
	.long LDIFF_SYM54
Lfde5_start:

	.long 0
	.align 3
	.quad JPush_APService_BeginLogPageView_string_int

LDIFF_SYM55=Lme_13 - JPush_APService_BeginLogPageView_string_int
	.long LDIFF_SYM55
	.long 0
	.byte 12,31,0,68,14,128,1,157,16,158,15,68,13,29,68,152,14,153,13
	.align 3
Lfde5_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "JPush.APService:ClearAllLocalNotifications"
	.asciz "JPush_APService_ClearAllLocalNotifications"

	.byte 2,88
	.quad JPush_APService_ClearAllLocalNotifications
	.quad Lme_14

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM56=Lfde6_end - Lfde6_start
	.long LDIFF_SYM56
Lfde6_start:

	.long 0
	.align 3
	.quad JPush_APService_ClearAllLocalNotifications

LDIFF_SYM57=Lme_14 - JPush_APService_ClearAllLocalNotifications
	.long LDIFF_SYM57
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29
	.align 3
Lfde6_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "JPush.APService:CrashLogON"
	.asciz "JPush_APService_CrashLogON"

	.byte 2,95
	.quad JPush_APService_CrashLogON
	.quad Lme_15

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM58=Lfde7_end - Lfde7_start
	.long LDIFF_SYM58
Lfde7_start:

	.long 0
	.align 3
	.quad JPush_APService_CrashLogON

LDIFF_SYM59=Lme_15 - JPush_APService_CrashLogON
	.long LDIFF_SYM59
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29
	.align 3
Lfde7_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_7:

	.byte 5
	.asciz "UIKit_UILocalNotification"

	.byte 40,16
LDIFF_SYM60=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM60
	.byte 2,35,0,0,7
	.asciz "UIKit_UILocalNotification"

LDIFF_SYM61=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM61
LTDIE_7_POINTER:

	.byte 13
LDIFF_SYM62=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM62
LTDIE_7_REFERENCE:

	.byte 14
LDIFF_SYM63=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM63
	.byte 2
	.asciz "JPush.APService:DeleteLocalNotification"
	.asciz "JPush_APService_DeleteLocalNotification_UIKit_UILocalNotification"

	.byte 2,102
	.quad JPush_APService_DeleteLocalNotification_UIKit_UILocalNotification
	.quad Lme_16

	.byte 2,118,16,3
	.asciz "localNotification"

LDIFF_SYM64=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM64
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM65=Lfde8_end - Lfde8_start
	.long LDIFF_SYM65
Lfde8_start:

	.long 0
	.align 3
	.quad JPush_APService_DeleteLocalNotification_UIKit_UILocalNotification

LDIFF_SYM66=Lme_16 - JPush_APService_DeleteLocalNotification_UIKit_UILocalNotification
	.long LDIFF_SYM66
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,154,8
	.align 3
Lfde8_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "JPush.APService:DeleteLocalNotificationWithIdentifierKey"
	.asciz "JPush_APService_DeleteLocalNotificationWithIdentifierKey_string"

	.byte 2,111
	.quad JPush_APService_DeleteLocalNotificationWithIdentifierKey_string
	.quad Lme_17

	.byte 2,118,16,3
	.asciz "notificationKey"

LDIFF_SYM67=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM67
	.byte 1,106,11
	.asciz "nsnotificationKey"

LDIFF_SYM68=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM68
	.byte 1,105,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM69=Lfde9_end - Lfde9_start
	.long LDIFF_SYM69
Lfde9_start:

	.long 0
	.align 3
	.quad JPush_APService_DeleteLocalNotificationWithIdentifierKey_string

LDIFF_SYM70=Lme_17 - JPush_APService_DeleteLocalNotificationWithIdentifierKey_string
	.long LDIFF_SYM70
	.long 0
	.byte 12,31,0,68,14,112,157,14,158,13,68,13,29,68,153,12,154,11
	.align 3
Lfde9_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_8:

	.byte 5
	.asciz "Foundation_NSSet"

	.byte 40,16
LDIFF_SYM71=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM71
	.byte 2,35,0,0,7
	.asciz "Foundation_NSSet"

LDIFF_SYM72=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM72
LTDIE_8_POINTER:

	.byte 13
LDIFF_SYM73=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM73
LTDIE_8_REFERENCE:

	.byte 14
LDIFF_SYM74=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM74
	.byte 2
	.asciz "JPush.APService:FilterValidTags"
	.asciz "JPush_APService_FilterValidTags_Foundation_NSSet"

	.byte 2,124
	.quad JPush_APService_FilterValidTags_Foundation_NSSet
	.quad Lme_18

	.byte 2,118,16,3
	.asciz "tags"

LDIFF_SYM75=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM75
	.byte 1,106,11
	.asciz ""

LDIFF_SYM76=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM76
	.byte 1,105,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM77=Lfde10_end - Lfde10_start
	.long LDIFF_SYM77
Lfde10_start:

	.long 0
	.align 3
	.quad JPush_APService_FilterValidTags_Foundation_NSSet

LDIFF_SYM78=Lme_18 - JPush_APService_FilterValidTags_Foundation_NSSet
	.long LDIFF_SYM78
	.long 0
	.byte 12,31,0,68,14,112,157,14,158,13,68,13,29,68,153,12,154,11
	.align 3
Lfde10_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "JPush.APService:FindLocalNotificationWithIdentifier"
	.asciz "JPush_APService_FindLocalNotificationWithIdentifier_string"

	.byte 2,133,1
	.quad JPush_APService_FindLocalNotificationWithIdentifier_string
	.quad Lme_19

	.byte 2,118,16,3
	.asciz "notificationKey"

LDIFF_SYM79=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM79
	.byte 1,106,11
	.asciz "nsnotificationKey"

LDIFF_SYM80=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM80
	.byte 1,105,11
	.asciz "ret"

LDIFF_SYM81=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM81
	.byte 1,104,11
	.asciz ""

LDIFF_SYM82=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM82
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM83=Lfde11_end - Lfde11_start
	.long LDIFF_SYM83
Lfde11_start:

	.long 0
	.align 3
	.quad JPush_APService_FindLocalNotificationWithIdentifier_string

LDIFF_SYM84=Lme_19 - JPush_APService_FindLocalNotificationWithIdentifier_string
	.long LDIFF_SYM84
	.long 0
	.byte 12,31,0,68,14,144,1,157,18,158,17,68,13,29,68,151,16,152,15,68,153,14,154,13
	.align 3
Lfde11_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_9:

	.byte 5
	.asciz "Foundation_NSDictionary"

	.byte 40,16
LDIFF_SYM85=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM85
	.byte 2,35,0,0,7
	.asciz "Foundation_NSDictionary"

LDIFF_SYM86=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM86
LTDIE_9_POINTER:

	.byte 13
LDIFF_SYM87=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM87
LTDIE_9_REFERENCE:

	.byte 14
LDIFF_SYM88=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM88
	.byte 2
	.asciz "JPush.APService:HandleRemoteNotification"
	.asciz "JPush_APService_HandleRemoteNotification_Foundation_NSDictionary"

	.byte 2,148,1
	.quad JPush_APService_HandleRemoteNotification_Foundation_NSDictionary
	.quad Lme_1a

	.byte 2,118,16,3
	.asciz "remoteInfo"

LDIFF_SYM89=LTDIE_9_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM89
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM90=Lfde12_end - Lfde12_start
	.long LDIFF_SYM90
Lfde12_start:

	.long 0
	.align 3
	.quad JPush_APService_HandleRemoteNotification_Foundation_NSDictionary

LDIFF_SYM91=Lme_1a - JPush_APService_HandleRemoteNotification_Foundation_NSDictionary
	.long LDIFF_SYM91
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,154,8
	.align 3
Lfde12_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_10:

	.byte 5
	.asciz "Foundation_NSData"

	.byte 40,16
LDIFF_SYM92=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM92
	.byte 2,35,0,0,7
	.asciz "Foundation_NSData"

LDIFF_SYM93=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM93
LTDIE_10_POINTER:

	.byte 13
LDIFF_SYM94=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM94
LTDIE_10_REFERENCE:

	.byte 14
LDIFF_SYM95=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM95
	.byte 2
	.asciz "JPush.APService:RegisterDeviceToken"
	.asciz "JPush_APService_RegisterDeviceToken_Foundation_NSData"

	.byte 2,157,1
	.quad JPush_APService_RegisterDeviceToken_Foundation_NSData
	.quad Lme_1b

	.byte 2,118,16,3
	.asciz "deviceToken"

LDIFF_SYM96=LTDIE_10_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM96
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM97=Lfde13_end - Lfde13_start
	.long LDIFF_SYM97
Lfde13_start:

	.long 0
	.align 3
	.quad JPush_APService_RegisterDeviceToken_Foundation_NSData

LDIFF_SYM98=Lme_1b - JPush_APService_RegisterDeviceToken_Foundation_NSData
	.long LDIFF_SYM98
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,154,8
	.align 3
Lfde13_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "JPush.APService:RegisterForRemoteNotificationTypes"
	.asciz "JPush_APService_RegisterForRemoteNotificationTypes_System_nuint_Foundation_NSSet"

	.byte 2,166,1
	.quad JPush_APService_RegisterForRemoteNotificationTypes_System_nuint_Foundation_NSSet
	.quad Lme_1c

	.byte 2,118,16,3
	.asciz "types"

LDIFF_SYM99=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM99
	.byte 2,141,56,3
	.asciz "categories"

LDIFF_SYM100=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM100
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM101=Lfde14_end - Lfde14_start
	.long LDIFF_SYM101
Lfde14_start:

	.long 0
	.align 3
	.quad JPush_APService_RegisterForRemoteNotificationTypes_System_nuint_Foundation_NSSet

LDIFF_SYM102=Lme_1c - JPush_APService_RegisterForRemoteNotificationTypes_System_nuint_Foundation_NSSet
	.long LDIFF_SYM102
	.long 0
	.byte 12,31,0,68,14,112,157,14,158,13,68,13,29,68,149,12,150,11,68,151,10,152,9,68,154,8
	.align 3
Lfde14_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "JPush.APService:ResetBadge"
	.asciz "JPush_APService_ResetBadge"

	.byte 2,173,1
	.quad JPush_APService_ResetBadge
	.quad Lme_1d

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM103=Lfde15_end - Lfde15_start
	.long LDIFF_SYM103
Lfde15_start:

	.long 0
	.align 3
	.quad JPush_APService_ResetBadge

LDIFF_SYM104=Lme_1d - JPush_APService_ResetBadge
	.long LDIFF_SYM104
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29
	.align 3
Lfde15_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_11:

	.byte 5
	.asciz "ObjCRuntime_Selector"

	.byte 32,16
LDIFF_SYM105=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM105
	.byte 2,35,0,6
	.asciz "handle"

LDIFF_SYM106=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM106
	.byte 2,35,24,6
	.asciz "name"

LDIFF_SYM107=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM107
	.byte 2,35,16,0,7
	.asciz "ObjCRuntime_Selector"

LDIFF_SYM108=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM108
LTDIE_11_POINTER:

	.byte 13
LDIFF_SYM109=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM109
LTDIE_11_REFERENCE:

	.byte 14
LDIFF_SYM110=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM110
	.byte 2
	.asciz "JPush.APService:SetAlias"
	.asciz "JPush_APService_SetAlias_string_ObjCRuntime_Selector_Foundation_NSObject"

	.byte 2,180,1
	.quad JPush_APService_SetAlias_string_ObjCRuntime_Selector_Foundation_NSObject
	.quad Lme_1e

	.byte 2,118,16,3
	.asciz "alias"

LDIFF_SYM111=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM111
	.byte 3,141,200,0,3
	.asciz "cbSelector"

LDIFF_SYM112=LTDIE_11_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM112
	.byte 1,105,3
	.asciz "theTarget"

LDIFF_SYM113=LTDIE_1_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM113
	.byte 3,141,208,0,11
	.asciz "nsalias"

LDIFF_SYM114=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM114
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM115=Lfde16_end - Lfde16_start
	.long LDIFF_SYM115
Lfde16_start:

	.long 0
	.align 3
	.quad JPush_APService_SetAlias_string_ObjCRuntime_Selector_Foundation_NSObject

LDIFF_SYM116=Lme_1e - JPush_APService_SetAlias_string_ObjCRuntime_Selector_Foundation_NSObject
	.long LDIFF_SYM116
	.long 0
	.byte 12,31,0,68,14,176,1,157,22,158,21,68,13,29,68,147,20,148,19,68,149,18,150,17,68,151,16,68,153,15,154,14
	.align 3
Lfde16_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_12:

	.byte 5
	.asciz "System_Boolean"

	.byte 17,16
LDIFF_SYM117=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM117
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM118=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM118
	.byte 2,35,16,0,7
	.asciz "System_Boolean"

LDIFF_SYM119=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM119
LTDIE_12_POINTER:

	.byte 13
LDIFF_SYM120=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM120
LTDIE_12_REFERENCE:

	.byte 14
LDIFF_SYM121=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM121
	.byte 2
	.asciz "JPush.APService:SetBadge"
	.asciz "JPush_APService_SetBadge_System_nint"

	.byte 2,191,1
	.quad JPush_APService_SetBadge_System_nint
	.quad Lme_1f

	.byte 2,118,16,3
	.asciz "value"

LDIFF_SYM122=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM122
	.byte 2,141,24,11
	.asciz ""

LDIFF_SYM123=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM123
	.byte 1,105,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM124=Lfde17_end - Lfde17_start
	.long LDIFF_SYM124
Lfde17_start:

	.long 0
	.align 3
	.quad JPush_APService_SetBadge_System_nint

LDIFF_SYM125=Lme_1f - JPush_APService_SetBadge_System_nint
	.long LDIFF_SYM125
	.long 0
	.byte 12,31,0,68,14,112,157,14,158,13,68,13,29,68,153,12
	.align 3
Lfde17_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "JPush.APService:SetDebugMode"
	.asciz "JPush_APService_SetDebugMode"

	.byte 2,198,1
	.quad JPush_APService_SetDebugMode
	.quad Lme_20

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM126=Lfde18_end - Lfde18_start
	.long LDIFF_SYM126
Lfde18_start:

	.long 0
	.align 3
	.quad JPush_APService_SetDebugMode

LDIFF_SYM127=Lme_20 - JPush_APService_SetDebugMode
	.long LDIFF_SYM127
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29
	.align 3
Lfde18_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_13:

	.byte 5
	.asciz "System_Double"

	.byte 24,16
LDIFF_SYM128=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM128
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM129=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM129
	.byte 2,35,16,0,7
	.asciz "System_Double"

LDIFF_SYM130=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM130
LTDIE_13_POINTER:

	.byte 13
LDIFF_SYM131=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM131
LTDIE_13_REFERENCE:

	.byte 14
LDIFF_SYM132=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM132
	.byte 2
	.asciz "JPush.APService:SetLatitude"
	.asciz "JPush_APService_SetLatitude_double_double"

	.byte 2,205,1
	.quad JPush_APService_SetLatitude_double_double
	.quad Lme_21

	.byte 2,118,16,3
	.asciz "latitude"

LDIFF_SYM133=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM133
	.byte 2,141,16,3
	.asciz "longitude"

LDIFF_SYM134=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM134
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM135=Lfde19_end - Lfde19_start
	.long LDIFF_SYM135
Lfde19_start:

	.long 0
	.align 3
	.quad JPush_APService_SetLatitude_double_double

LDIFF_SYM136=Lme_21 - JPush_APService_SetLatitude_double_double
	.long LDIFF_SYM136
	.long 0
	.byte 12,31,0,68,14,96,157,12,158,11,68,13,29
	.align 3
Lfde19_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_14:

	.byte 5
	.asciz "Foundation_NSDate"

	.byte 40,16
LDIFF_SYM137=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM137
	.byte 2,35,0,0,7
	.asciz "Foundation_NSDate"

LDIFF_SYM138=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM138
LTDIE_14_POINTER:

	.byte 13
LDIFF_SYM139=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM139
LTDIE_14_REFERENCE:

	.byte 14
LDIFF_SYM140=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM140
	.byte 2
	.asciz "JPush.APService:SetLocalNotification"
	.asciz "JPush_APService_SetLocalNotification_Foundation_NSDate_string_int_string_string_Foundation_NSDictionary_string"

	.byte 2,212,1
	.quad JPush_APService_SetLocalNotification_Foundation_NSDate_string_int_string_string_Foundation_NSDictionary_string
	.quad Lme_22

	.byte 2,118,16,3
	.asciz "fireDate"

LDIFF_SYM141=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM141
	.byte 1,100,3
	.asciz "alertBody"

LDIFF_SYM142=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM142
	.byte 1,101,3
	.asciz "badge"

LDIFF_SYM143=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM143
	.byte 3,141,192,0,3
	.asciz "alertActionText"

LDIFF_SYM144=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM144
	.byte 1,103,3
	.asciz "notificationKey"

LDIFF_SYM145=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM145
	.byte 1,104,3
	.asciz "userInfo"

LDIFF_SYM146=LTDIE_9_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM146
	.byte 1,105,3
	.asciz "soundName"

LDIFF_SYM147=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM147
	.byte 3,141,200,0,11
	.asciz "nsalertBody"

LDIFF_SYM148=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM148
	.byte 1,99,11
	.asciz "nsalertActionText"

LDIFF_SYM149=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM149
	.byte 3,141,232,0,11
	.asciz "nsnotificationKey"

LDIFF_SYM150=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM150
	.byte 3,141,240,0,11
	.asciz "nssoundName"

LDIFF_SYM151=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM151
	.byte 3,141,248,0,11
	.asciz "ret"

LDIFF_SYM152=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM152
	.byte 3,141,128,1,11
	.asciz ""

LDIFF_SYM153=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM153
	.byte 3,141,136,1,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM154=Lfde20_end - Lfde20_start
	.long LDIFF_SYM154
Lfde20_start:

	.long 0
	.align 3
	.quad JPush_APService_SetLocalNotification_Foundation_NSDate_string_int_string_string_Foundation_NSDictionary_string

LDIFF_SYM155=Lme_22 - JPush_APService_SetLocalNotification_Foundation_NSDate_string_int_string_string_Foundation_NSDictionary_string
	.long LDIFF_SYM155
	.long 0
	.byte 12,31,0,68,14,176,2,157,38,158,37,68,13,29,84,147,36,148,35,68,149,34,68,151,33,152,32,68,153,31
	.align 3
Lfde20_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_15:

	.byte 5
	.asciz "CoreLocation_CLRegion"

	.byte 40,16
LDIFF_SYM156=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM156
	.byte 2,35,0,0,7
	.asciz "CoreLocation_CLRegion"

LDIFF_SYM157=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM157
LTDIE_15_POINTER:

	.byte 13
LDIFF_SYM158=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM158
LTDIE_15_REFERENCE:

	.byte 14
LDIFF_SYM159=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM159
	.byte 2
	.asciz "JPush.APService:SetLocalNotification"
	.asciz "JPush_APService_SetLocalNotification_Foundation_NSDate_string_int_string_string_Foundation_NSDictionary_string_CoreLocation_CLRegion_bool_string"

	.byte 2,241,1
	.quad JPush_APService_SetLocalNotification_Foundation_NSDate_string_int_string_string_Foundation_NSDictionary_string_CoreLocation_CLRegion_bool_string
	.quad Lme_23

	.byte 2,118,16,3
	.asciz "fireDate"

LDIFF_SYM160=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM160
	.byte 3,141,216,0,3
	.asciz "alertBody"

LDIFF_SYM161=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM161
	.byte 1,105,3
	.asciz "badge"

LDIFF_SYM162=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM162
	.byte 3,141,224,0,3
	.asciz "alertActionText"

LDIFF_SYM163=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM163
	.byte 3,141,232,0,3
	.asciz "notificationKey"

LDIFF_SYM164=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM164
	.byte 3,141,240,0,3
	.asciz "userInfo"

LDIFF_SYM165=LTDIE_9_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM165
	.byte 3,141,248,0,3
	.asciz "soundName"

LDIFF_SYM166=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM166
	.byte 3,141,128,1,3
	.asciz "region"

LDIFF_SYM167=LTDIE_15_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM167
	.byte 3,141,136,1,3
	.asciz "regionTriggersOnce"

LDIFF_SYM168=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM168
	.byte 2,140,0,3
	.asciz "category"

LDIFF_SYM169=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM169
	.byte 2,140,8,11
	.asciz "nsalertBody"

LDIFF_SYM170=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM170
	.byte 1,104,11
	.asciz "nsalertActionText"

LDIFF_SYM171=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM171
	.byte 1,102,11
	.asciz "nsnotificationKey"

LDIFF_SYM172=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM172
	.byte 1,99,11
	.asciz "nssoundName"

LDIFF_SYM173=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM173
	.byte 1,106,11
	.asciz "nscategory"

LDIFF_SYM174=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM174
	.byte 1,103,11
	.asciz "ret"

LDIFF_SYM175=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM175
	.byte 1,101,11
	.asciz ""

LDIFF_SYM176=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM176
	.byte 1,100,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM177=Lfde21_end - Lfde21_start
	.long LDIFF_SYM177
Lfde21_start:

	.long 0
	.align 3
	.quad JPush_APService_SetLocalNotification_Foundation_NSDate_string_int_string_string_Foundation_NSDictionary_string_CoreLocation_CLRegion_bool_string

LDIFF_SYM178=Lme_23 - JPush_APService_SetLocalNotification_Foundation_NSDate_string_int_string_string_Foundation_NSDictionary_string_CoreLocation_CLRegion_bool_string
	.long LDIFF_SYM178
	.long 0
	.byte 12,31,0,68,14,176,3,157,54,158,53,68,13,29,84,147,52,148,51,68,149,50,150,49,68,151,48,152,47,68,153,46
	.byte 154,45,68,156,44
	.align 3
Lfde21_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_16:

	.byte 5
	.asciz "CoreLocation_CLLocation"

	.byte 40,16
LDIFF_SYM179=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM179
	.byte 2,35,0,0,7
	.asciz "CoreLocation_CLLocation"

LDIFF_SYM180=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM180
LTDIE_16_POINTER:

	.byte 13
LDIFF_SYM181=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM181
LTDIE_16_REFERENCE:

	.byte 14
LDIFF_SYM182=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM182
	.byte 2
	.asciz "JPush.APService:SetLocation"
	.asciz "JPush_APService_SetLocation_CoreLocation_CLLocation"

	.byte 2,150,2
	.quad JPush_APService_SetLocation_CoreLocation_CLLocation
	.quad Lme_24

	.byte 2,118,16,3
	.asciz "location"

LDIFF_SYM183=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM183
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM184=Lfde22_end - Lfde22_start
	.long LDIFF_SYM184
Lfde22_start:

	.long 0
	.align 3
	.quad JPush_APService_SetLocation_CoreLocation_CLLocation

LDIFF_SYM185=Lme_24 - JPush_APService_SetLocation_CoreLocation_CLLocation
	.long LDIFF_SYM185
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,154,8
	.align 3
Lfde22_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "JPush.APService:SetLogOFF"
	.asciz "JPush_APService_SetLogOFF"

	.byte 2,159,2
	.quad JPush_APService_SetLogOFF
	.quad Lme_25

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM186=Lfde23_end - Lfde23_start
	.long LDIFF_SYM186
Lfde23_start:

	.long 0
	.align 3
	.quad JPush_APService_SetLogOFF

LDIFF_SYM187=Lme_25 - JPush_APService_SetLogOFF
	.long LDIFF_SYM187
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29
	.align 3
Lfde23_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "JPush.APService:SetTagsWithObject"
	.asciz "JPush_APService_SetTagsWithObject_Foundation_NSSet_string_ObjCRuntime_Selector_Foundation_NSObject"

	.byte 2,166,2
	.quad JPush_APService_SetTagsWithObject_Foundation_NSSet_string_ObjCRuntime_Selector_Foundation_NSObject
	.quad Lme_26

	.byte 2,118,16,3
	.asciz "tags"

LDIFF_SYM188=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM188
	.byte 1,103,3
	.asciz "alias"

LDIFF_SYM189=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM189
	.byte 3,141,200,0,3
	.asciz "cbSelector"

LDIFF_SYM190=LTDIE_11_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM190
	.byte 3,141,208,0,3
	.asciz "theTarget"

LDIFF_SYM191=LTDIE_1_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM191
	.byte 3,141,216,0,11
	.asciz "nsalias"

LDIFF_SYM192=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM192
	.byte 1,102,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM193=Lfde24_end - Lfde24_start
	.long LDIFF_SYM193
Lfde24_start:

	.long 0
	.align 3
	.quad JPush_APService_SetTagsWithObject_Foundation_NSSet_string_ObjCRuntime_Selector_Foundation_NSObject

LDIFF_SYM194=Lme_26 - JPush_APService_SetTagsWithObject_Foundation_NSSet_string_ObjCRuntime_Selector_Foundation_NSObject
	.long LDIFF_SYM194
	.long 0
	.byte 12,31,0,68,14,160,1,157,20,158,19,68,13,29,68,147,18,148,17,68,149,16,150,15,68,151,14,68,153,13,154,12
	.align 3
Lfde24_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "JPush.APService:SetTagsWithTarger"
	.asciz "JPush_APService_SetTagsWithTarger_Foundation_NSSet_string_ObjCRuntime_Selector_Foundation_NSObject"

	.byte 2,177,2
	.quad JPush_APService_SetTagsWithTarger_Foundation_NSSet_string_ObjCRuntime_Selector_Foundation_NSObject
	.quad Lme_27

	.byte 2,118,16,3
	.asciz "tags"

LDIFF_SYM195=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM195
	.byte 1,103,3
	.asciz "alias"

LDIFF_SYM196=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM196
	.byte 3,141,200,0,3
	.asciz "cbSelector"

LDIFF_SYM197=LTDIE_11_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM197
	.byte 3,141,208,0,3
	.asciz "theTarget"

LDIFF_SYM198=LTDIE_1_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM198
	.byte 3,141,216,0,11
	.asciz "nsalias"

LDIFF_SYM199=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM199
	.byte 1,102,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM200=Lfde25_end - Lfde25_start
	.long LDIFF_SYM200
Lfde25_start:

	.long 0
	.align 3
	.quad JPush_APService_SetTagsWithTarger_Foundation_NSSet_string_ObjCRuntime_Selector_Foundation_NSObject

LDIFF_SYM201=Lme_27 - JPush_APService_SetTagsWithTarger_Foundation_NSSet_string_ObjCRuntime_Selector_Foundation_NSObject
	.long LDIFF_SYM201
	.long 0
	.byte 12,31,0,68,14,160,1,157,20,158,19,68,13,29,68,147,18,148,17,68,149,16,150,15,68,151,14,68,153,13,154,12
	.align 3
Lfde25_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "JPush.APService:SetTagsWithTarget"
	.asciz "JPush_APService_SetTagsWithTarget_Foundation_NSSet_ObjCRuntime_Selector_Foundation_NSObject"

	.byte 2,188,2
	.quad JPush_APService_SetTagsWithTarget_Foundation_NSSet_ObjCRuntime_Selector_Foundation_NSObject
	.quad Lme_28

	.byte 2,118,16,3
	.asciz "tags"

LDIFF_SYM202=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM202
	.byte 1,104,3
	.asciz "cbSelector"

LDIFF_SYM203=LTDIE_11_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM203
	.byte 1,105,3
	.asciz "theTarget"

LDIFF_SYM204=LTDIE_1_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM204
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM205=Lfde26_end - Lfde26_start
	.long LDIFF_SYM205
Lfde26_start:

	.long 0
	.align 3
	.quad JPush_APService_SetTagsWithTarget_Foundation_NSSet_ObjCRuntime_Selector_Foundation_NSObject

LDIFF_SYM206=Lme_28 - JPush_APService_SetTagsWithTarget_Foundation_NSSet_ObjCRuntime_Selector_Foundation_NSObject
	.long LDIFF_SYM206
	.long 0
	.byte 12,31,0,68,14,128,1,157,16,158,15,68,13,29,68,147,14,148,13,68,149,12,150,11,68,151,10,152,9,68,153,8
	.byte 154,7
	.align 3
Lfde26_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "JPush.APService:SetupWithOption"
	.asciz "JPush_APService_SetupWithOption_Foundation_NSDictionary"

	.byte 2,195,2
	.quad JPush_APService_SetupWithOption_Foundation_NSDictionary
	.quad Lme_29

	.byte 2,118,16,3
	.asciz "launchingOption"

LDIFF_SYM207=LTDIE_9_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM207
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM208=Lfde27_end - Lfde27_start
	.long LDIFF_SYM208
Lfde27_start:

	.long 0
	.align 3
	.quad JPush_APService_SetupWithOption_Foundation_NSDictionary

LDIFF_SYM209=Lme_29 - JPush_APService_SetupWithOption_Foundation_NSDictionary
	.long LDIFF_SYM209
	.long 0
	.byte 12,31,0,68,14,96,157,12,158,11,68,13,29,68,151,10,152,9,68,153,8,154,7
	.align 3
Lfde27_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "JPush.APService:ShowLocalNotificationAtFront"
	.asciz "JPush_APService_ShowLocalNotificationAtFront_UIKit_UILocalNotification_string"

	.byte 2,202,2
	.quad JPush_APService_ShowLocalNotificationAtFront_UIKit_UILocalNotification_string
	.quad Lme_2a

	.byte 2,118,16,3
	.asciz "notification"

LDIFF_SYM210=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM210
	.byte 1,105,3
	.asciz "notificationKey"

LDIFF_SYM211=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM211
	.byte 1,106,11
	.asciz "nsnotificationKey"

LDIFF_SYM212=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM212
	.byte 1,104,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM213=Lfde28_end - Lfde28_start
	.long LDIFF_SYM213
Lfde28_start:

	.long 0
	.align 3
	.quad JPush_APService_ShowLocalNotificationAtFront_UIKit_UILocalNotification_string

LDIFF_SYM214=Lme_2a - JPush_APService_ShowLocalNotificationAtFront_UIKit_UILocalNotification_string
	.long LDIFF_SYM214
	.long 0
	.byte 12,31,0,68,14,112,157,14,158,13,68,13,29,68,152,12,153,11,68,154,10
	.align 3
Lfde28_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "JPush.APService:StartLogPageView"
	.asciz "JPush_APService_StartLogPageView_string"

	.byte 2,217,2
	.quad JPush_APService_StartLogPageView_string
	.quad Lme_2b

	.byte 2,118,16,3
	.asciz "pageName"

LDIFF_SYM215=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM215
	.byte 1,106,11
	.asciz "nspageName"

LDIFF_SYM216=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM216
	.byte 1,105,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM217=Lfde29_end - Lfde29_start
	.long LDIFF_SYM217
Lfde29_start:

	.long 0
	.align 3
	.quad JPush_APService_StartLogPageView_string

LDIFF_SYM218=Lme_2b - JPush_APService_StartLogPageView_string
	.long LDIFF_SYM218
	.long 0
	.byte 12,31,0,68,14,112,157,14,158,13,68,13,29,68,153,12,154,11
	.align 3
Lfde29_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "JPush.APService:StopLogPageView"
	.asciz "JPush_APService_StopLogPageView_string"

	.byte 2,230,2
	.quad JPush_APService_StopLogPageView_string
	.quad Lme_2c

	.byte 2,118,16,3
	.asciz "pageName"

LDIFF_SYM219=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM219
	.byte 1,106,11
	.asciz "nspageName"

LDIFF_SYM220=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM220
	.byte 1,105,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM221=Lfde30_end - Lfde30_start
	.long LDIFF_SYM221
Lfde30_start:

	.long 0
	.align 3
	.quad JPush_APService_StopLogPageView_string

LDIFF_SYM222=Lme_2c - JPush_APService_StopLogPageView_string
	.long LDIFF_SYM222
	.long 0
	.byte 12,31,0,68,14,112,157,14,158,13,68,13,29,68,153,12,154,11
	.align 3
Lfde30_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "JPush.APService:get_RegistrationID"
	.asciz "JPush_APService_get_RegistrationID"

	.byte 2,243,2
	.quad JPush_APService_get_RegistrationID
	.quad Lme_2d

	.byte 2,118,16,11
	.asciz ""

LDIFF_SYM223=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM223
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM224=Lfde31_end - Lfde31_start
	.long LDIFF_SYM224
Lfde31_start:

	.long 0
	.align 3
	.quad JPush_APService_get_RegistrationID

LDIFF_SYM225=Lme_2d - JPush_APService_get_RegistrationID
	.long LDIFF_SYM225
	.long 0
	.byte 12,31,0,68,14,96,157,12,158,11,68,13,29,68,154,10
	.align 3
Lfde31_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "JPush.APService:.cctor"
	.asciz "JPush_APService__cctor"

	.byte 2,41
	.quad JPush_APService__cctor
	.quad Lme_2e

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM226=Lfde32_end - Lfde32_start
	.long LDIFF_SYM226
Lfde32_start:

	.long 0
	.align 3
	.quad JPush_APService__cctor

LDIFF_SYM227=Lme_2e - JPush_APService__cctor
	.long LDIFF_SYM227
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29
	.align 3
Lfde32_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper managed-to-native) ApiDefinition.Messaging:IntPtr_objc_msgSend"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr
	.quad Lme_30

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM228=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM228
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM229=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM229
	.byte 2,141,24,11
	.asciz "V_0"

LDIFF_SYM230=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM230
	.byte 3,141,176,1,11
	.asciz "V_1"

LDIFF_SYM231=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM231
	.byte 3,141,184,1,11
	.asciz "V_2"

LDIFF_SYM232=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM232
	.byte 3,141,192,1,11
	.asciz "V_3"

LDIFF_SYM233=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM233
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM234=Lfde33_end - Lfde33_start
	.long LDIFF_SYM234
Lfde33_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr

LDIFF_SYM235=Lme_30 - wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr
	.long LDIFF_SYM235
	.long 0
	.byte 12,31,0,68,14,208,1,157,26,158,25,68,13,29,76,147,16,148,15,68,149,14,150,13,68,151,12,152,11,68,153,10
	.byte 154,9,68,155,8,156,7
	.align 3
Lfde33_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper managed-to-native) ApiDefinition.Messaging:IntPtr_objc_msgSendSuper"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr
	.quad Lme_31

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM236=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM236
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM237=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM237
	.byte 2,141,24,11
	.asciz "V_0"

LDIFF_SYM238=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM238
	.byte 3,141,176,1,11
	.asciz "V_1"

LDIFF_SYM239=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM239
	.byte 3,141,184,1,11
	.asciz "V_2"

LDIFF_SYM240=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM240
	.byte 3,141,192,1,11
	.asciz "V_3"

LDIFF_SYM241=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM241
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM242=Lfde34_end - Lfde34_start
	.long LDIFF_SYM242
Lfde34_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr

LDIFF_SYM243=Lme_31 - wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr
	.long LDIFF_SYM243
	.long 0
	.byte 12,31,0,68,14,208,1,157,26,158,25,68,13,29,76,147,16,148,15,68,149,14,150,13,68,151,12,152,11,68,153,10
	.byte 154,9,68,155,8,156,7
	.align 3
Lfde34_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper managed-to-native) ApiDefinition.Messaging:IntPtr_objc_msgSend_IntPtr"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr
	.quad Lme_32

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM244=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM244
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM245=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM245
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM246=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM246
	.byte 2,141,32,11
	.asciz "V_0"

LDIFF_SYM247=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM247
	.byte 3,141,184,1,11
	.asciz "V_1"

LDIFF_SYM248=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM248
	.byte 3,141,192,1,11
	.asciz "V_2"

LDIFF_SYM249=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM249
	.byte 3,141,200,1,11
	.asciz "V_3"

LDIFF_SYM250=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM250
	.byte 1,102,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM251=Lfde35_end - Lfde35_start
	.long LDIFF_SYM251
Lfde35_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr

LDIFF_SYM252=Lme_32 - wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr
	.long LDIFF_SYM252
	.long 0
	.byte 12,31,0,68,14,208,1,157,26,158,25,68,13,29,76,147,15,148,14,68,149,13,150,12,68,151,11,152,10,68,153,9
	.byte 154,8,68,155,7,156,6
	.align 3
Lfde35_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper managed-to-native) ApiDefinition.Messaging:void_objc_msgSend_IntPtr"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr
	.quad Lme_33

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM253=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM253
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM254=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM254
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM255=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM255
	.byte 2,141,32,11
	.asciz "V_0"

LDIFF_SYM256=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM256
	.byte 3,141,184,1,11
	.asciz "V_1"

LDIFF_SYM257=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM257
	.byte 3,141,192,1,11
	.asciz "V_2"

LDIFF_SYM258=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM258
	.byte 3,141,200,1,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM259=Lfde36_end - Lfde36_start
	.long LDIFF_SYM259
Lfde36_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr

LDIFF_SYM260=Lme_33 - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr
	.long LDIFF_SYM260
	.long 0
	.byte 12,31,0,68,14,208,1,157,26,158,25,68,13,29,76,147,15,148,14,68,149,13,150,12,68,151,11,152,10,68,153,9
	.byte 154,8,68,155,7,156,6
	.align 3
Lfde36_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper managed-to-native) ApiDefinition.Messaging:void_objc_msgSend_nuint_IntPtr"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_nuint_IntPtr_intptr_intptr_System_nuint_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_nuint_IntPtr_intptr_intptr_System_nuint_intptr
	.quad Lme_34

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM261=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM261
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM262=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM262
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM263=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM263
	.byte 2,141,32,3
	.asciz "param3"

LDIFF_SYM264=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM264
	.byte 2,141,40,11
	.asciz "V_0"

LDIFF_SYM265=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM265
	.byte 3,141,192,1,11
	.asciz "V_1"

LDIFF_SYM266=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM266
	.byte 3,141,200,1,11
	.asciz "V_2"

LDIFF_SYM267=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM267
	.byte 3,141,208,1,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM268=Lfde37_end - Lfde37_start
	.long LDIFF_SYM268
Lfde37_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_nuint_IntPtr_intptr_intptr_System_nuint_intptr

LDIFF_SYM269=Lme_34 - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_nuint_IntPtr_intptr_intptr_System_nuint_intptr
	.long LDIFF_SYM269
	.long 0
	.byte 12,31,0,68,14,224,1,157,28,158,27,68,13,29,76,147,16,148,15,68,149,14,150,13,68,151,12,152,11,68,153,10
	.byte 154,9,68,155,8,156,7
	.align 3
Lfde37_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper managed-to-native) ApiDefinition.Messaging:void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_intptr_intptr
	.quad Lme_35

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM270=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM270
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM271=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM271
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM272=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM272
	.byte 2,141,32,3
	.asciz "param3"

LDIFF_SYM273=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM273
	.byte 2,141,40,3
	.asciz "param4"

LDIFF_SYM274=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM274
	.byte 2,141,48,3
	.asciz "param5"

LDIFF_SYM275=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM275
	.byte 2,141,56,11
	.asciz "V_0"

LDIFF_SYM276=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM276
	.byte 3,141,208,1,11
	.asciz "V_1"

LDIFF_SYM277=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM277
	.byte 3,141,216,1,11
	.asciz "V_2"

LDIFF_SYM278=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM278
	.byte 3,141,224,1,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM279=Lfde38_end - Lfde38_start
	.long LDIFF_SYM279
Lfde38_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_intptr_intptr

LDIFF_SYM280=Lme_35 - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_intptr_intptr
	.long LDIFF_SYM280
	.long 0
	.byte 12,31,0,68,14,128,2,157,32,158,31,68,13,29,76,147,18,148,17,68,149,16,150,15,68,151,14,152,13,68,153,12
	.byte 154,11,68,155,10,156,9
	.align 3
Lfde38_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper managed-to-native) ApiDefinition.Messaging:void_objc_msgSend_IntPtr_IntPtr_IntPtr"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_intptr
	.quad Lme_36

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM281=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM281
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM282=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM282
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM283=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM283
	.byte 2,141,32,3
	.asciz "param3"

LDIFF_SYM284=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM284
	.byte 2,141,40,3
	.asciz "param4"

LDIFF_SYM285=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM285
	.byte 2,141,48,11
	.asciz "V_0"

LDIFF_SYM286=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM286
	.byte 3,141,200,1,11
	.asciz "V_1"

LDIFF_SYM287=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM287
	.byte 3,141,208,1,11
	.asciz "V_2"

LDIFF_SYM288=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM288
	.byte 3,141,216,1,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM289=Lfde39_end - Lfde39_start
	.long LDIFF_SYM289
Lfde39_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_intptr

LDIFF_SYM290=Lme_36 - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_intptr
	.long LDIFF_SYM290
	.long 0
	.byte 12,31,0,68,14,240,1,157,30,158,29,68,13,29,76,147,17,148,16,68,149,15,150,14,68,151,13,152,12,68,153,11
	.byte 154,10,68,155,9,156,8
	.align 3
Lfde39_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper managed-to-native) ApiDefinition.Messaging:void_objc_msgSend_IntPtr_int"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_int_intptr_intptr_intptr_int"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_int_intptr_intptr_intptr_int
	.quad Lme_37

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM291=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM291
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM292=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM292
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM293=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM293
	.byte 2,141,32,3
	.asciz "param3"

LDIFF_SYM294=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM294
	.byte 2,141,40,11
	.asciz "V_0"

LDIFF_SYM295=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM295
	.byte 3,141,192,1,11
	.asciz "V_1"

LDIFF_SYM296=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM296
	.byte 3,141,200,1,11
	.asciz "V_2"

LDIFF_SYM297=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM297
	.byte 3,141,208,1,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM298=Lfde40_end - Lfde40_start
	.long LDIFF_SYM298
Lfde40_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_int_intptr_intptr_intptr_int

LDIFF_SYM299=Lme_37 - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_int_intptr_intptr_intptr_int
	.long LDIFF_SYM299
	.long 0
	.byte 12,31,0,68,14,224,1,157,28,158,27,68,13,29,76,147,16,148,15,68,149,14,150,13,68,151,12,152,11,68,153,10
	.byte 154,9,68,155,8,156,7
	.align 3
Lfde40_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper managed-to-native) ApiDefinition.Messaging:void_objc_msgSend"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr
	.quad Lme_38

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM300=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM300
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM301=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM301
	.byte 2,141,24,11
	.asciz "V_0"

LDIFF_SYM302=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM302
	.byte 3,141,176,1,11
	.asciz "V_1"

LDIFF_SYM303=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM303
	.byte 3,141,184,1,11
	.asciz "V_2"

LDIFF_SYM304=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM304
	.byte 3,141,192,1,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM305=Lfde41_end - Lfde41_start
	.long LDIFF_SYM305
Lfde41_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr

LDIFF_SYM306=Lme_38 - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr
	.long LDIFF_SYM306
	.long 0
	.byte 12,31,0,68,14,208,1,157,26,158,25,68,13,29,76,147,16,148,15,68,149,14,150,13,68,151,12,152,11,68,153,10
	.byte 154,9,68,155,8,156,7
	.align 3
Lfde41_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper managed-to-native) ApiDefinition.Messaging:void_objc_msgSend_Double_Double"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_Double_Double_intptr_intptr_double_double"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_Double_Double_intptr_intptr_double_double
	.quad Lme_39

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM307=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM307
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM308=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM308
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM309=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM309
	.byte 2,141,32,3
	.asciz "param3"

LDIFF_SYM310=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM310
	.byte 2,141,40,11
	.asciz "V_0"

LDIFF_SYM311=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM311
	.byte 3,141,192,1,11
	.asciz "V_1"

LDIFF_SYM312=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM312
	.byte 3,141,200,1,11
	.asciz "V_2"

LDIFF_SYM313=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM313
	.byte 3,141,208,1,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM314=Lfde42_end - Lfde42_start
	.long LDIFF_SYM314
Lfde42_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_Double_Double_intptr_intptr_double_double

LDIFF_SYM315=Lme_39 - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_Double_Double_intptr_intptr_double_double
	.long LDIFF_SYM315
	.long 0
	.byte 12,31,0,68,14,224,1,157,28,158,27,68,13,29,76,147,16,148,15,68,149,14,150,13,68,151,12,152,11,68,153,10
	.byte 154,9,68,155,8,156,7
	.align 3
Lfde42_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper managed-to-native) ApiDefinition.Messaging:IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_int_intptr_intptr_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_int_intptr_intptr_intptr_intptr
	.quad Lme_3a

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM316=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM316
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM317=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM317
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM318=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM318
	.byte 2,141,32,3
	.asciz "param3"

LDIFF_SYM319=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM319
	.byte 2,141,40,3
	.asciz "param4"

LDIFF_SYM320=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM320
	.byte 2,141,48,3
	.asciz "param5"

LDIFF_SYM321=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM321
	.byte 2,141,56,3
	.asciz "param6"

LDIFF_SYM322=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM322
	.byte 3,141,192,0,3
	.asciz "param7"

LDIFF_SYM323=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM323
	.byte 3,141,200,0,3
	.asciz "param8"

LDIFF_SYM324=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM324
	.byte 2,140,0,11
	.asciz "V_0"

LDIFF_SYM325=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM325
	.byte 3,141,224,1,11
	.asciz "V_1"

LDIFF_SYM326=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM326
	.byte 3,141,232,1,11
	.asciz "V_2"

LDIFF_SYM327=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM327
	.byte 3,141,240,1,11
	.asciz "V_3"

LDIFF_SYM328=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM328
	.byte 1,105,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM329=Lfde43_end - Lfde43_start
	.long LDIFF_SYM329
Lfde43_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_int_intptr_intptr_intptr_intptr

LDIFF_SYM330=Lme_3a - wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_intptr_intptr_intptr_intptr_int_intptr_intptr_intptr_intptr
	.long LDIFF_SYM330
	.long 0
	.byte 12,31,0,68,14,128,2,157,32,158,31,68,13,29,92,147,16,148,15,68,149,14,150,13,68,151,12,152,11,68,153,10
	.byte 154,9,68,155,8,156,7
	.align 3
Lfde43_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper managed-to-native) ApiDefinition.Messaging:IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool_IntPtr"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool_IntPtr_intptr_intptr_intptr_intptr_int_intptr_intptr_intptr_intptr_intptr_bool_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool_IntPtr_intptr_intptr_intptr_intptr_int_intptr_intptr_intptr_intptr_intptr_bool_intptr
	.quad Lme_3b

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM331=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM331
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM332=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM332
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM333=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM333
	.byte 2,141,32,3
	.asciz "param3"

LDIFF_SYM334=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM334
	.byte 2,141,40,3
	.asciz "param4"

LDIFF_SYM335=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM335
	.byte 2,141,48,3
	.asciz "param5"

LDIFF_SYM336=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM336
	.byte 2,141,56,3
	.asciz "param6"

LDIFF_SYM337=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM337
	.byte 3,141,192,0,3
	.asciz "param7"

LDIFF_SYM338=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM338
	.byte 3,141,200,0,3
	.asciz "param8"

LDIFF_SYM339=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM339
	.byte 2,140,0,3
	.asciz "param9"

LDIFF_SYM340=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM340
	.byte 2,140,8,3
	.asciz "param10"

LDIFF_SYM341=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM341
	.byte 2,140,16,3
	.asciz "param11"

LDIFF_SYM342=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM342
	.byte 2,140,24,11
	.asciz "V_0"

LDIFF_SYM343=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM343
	.byte 3,141,224,1,11
	.asciz "V_1"

LDIFF_SYM344=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM344
	.byte 3,141,232,1,11
	.asciz "V_2"

LDIFF_SYM345=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM345
	.byte 3,141,240,1,11
	.asciz "V_3"

LDIFF_SYM346=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM346
	.byte 1,104,11
	.asciz "V_4"

LDIFF_SYM347=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM347
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM348=Lfde44_end - Lfde44_start
	.long LDIFF_SYM348
Lfde44_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool_IntPtr_intptr_intptr_intptr_intptr_int_intptr_intptr_intptr_intptr_intptr_bool_intptr

LDIFF_SYM349=Lme_3b - wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool_IntPtr_intptr_intptr_intptr_intptr_int_intptr_intptr_intptr_intptr_intptr_bool_intptr
	.long LDIFF_SYM349
	.long 0
	.byte 12,31,0,68,14,128,2,157,32,158,31,68,13,29,92,147,16,148,15,68,149,14,150,13,68,151,12,152,11,68,153,10
	.byte 154,9,68,155,8,156,7
	.align 3
Lfde44_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper managed-to-native) ApiDefinition.Messaging:void_objc_msgSend_IntPtr_IntPtr"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr
	.quad Lme_3c

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM350=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM350
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM351=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM351
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM352=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM352
	.byte 2,141,32,3
	.asciz "param3"

LDIFF_SYM353=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM353
	.byte 2,141,40,11
	.asciz "V_0"

LDIFF_SYM354=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM354
	.byte 3,141,192,1,11
	.asciz "V_1"

LDIFF_SYM355=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM355
	.byte 3,141,200,1,11
	.asciz "V_2"

LDIFF_SYM356=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM356
	.byte 3,141,208,1,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM357=Lfde45_end - Lfde45_start
	.long LDIFF_SYM357
Lfde45_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr

LDIFF_SYM358=Lme_3c - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr
	.long LDIFF_SYM358
	.long 0
	.byte 12,31,0,68,14,224,1,157,28,158,27,68,13,29,76,147,16,148,15,68,149,14,150,13,68,151,12,152,11,68,153,10
	.byte 154,9,68,155,8,156,7
	.align 3
Lfde45_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper managed-to-native) ApiDefinition.Messaging:bool_objc_msgSend_nint"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSend_nint_intptr_intptr_System_nint"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSend_nint_intptr_intptr_System_nint
	.quad Lme_3d

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM359=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM359
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM360=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM360
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM361=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM361
	.byte 2,141,32,11
	.asciz "V_0"

LDIFF_SYM362=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM362
	.byte 3,141,184,1,11
	.asciz "V_1"

LDIFF_SYM363=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM363
	.byte 3,141,192,1,11
	.asciz "V_2"

LDIFF_SYM364=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM364
	.byte 3,141,200,1,11
	.asciz "V_3"

LDIFF_SYM365=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM365
	.byte 1,102,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM366=Lfde46_end - Lfde46_start
	.long LDIFF_SYM366
Lfde46_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSend_nint_intptr_intptr_System_nint

LDIFF_SYM367=Lme_3d - wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSend_nint_intptr_intptr_System_nint
	.long LDIFF_SYM367
	.long 0
	.byte 12,31,0,68,14,208,1,157,26,158,25,68,13,29,76,147,15,148,14,68,149,13,150,12,68,151,11,152,10,68,153,9
	.byte 154,8,68,155,7,156,6
	.align 3
Lfde46_end:

.section __DWARF, __debug_info,regular,debug

	.byte 0
Ldebug_info_end:
.section __DWARF, __debug_line,regular,debug
Ldebug_line_section_start:
Ldebug_line_start:

	.long Ldebug_line_end - . -4
	.short 2
	.long Ldebug_line_header_end - . -4
	.byte 1,1,251,14,13,0,1,1,1,1,0,0,0,1,0,0,1
.section __DWARF, __debug_line,regular,debug
	.asciz "/Users/shuoyang/Projects/lelaozu-Iphone/lelaozu-Iphone/JPush/obj/Debug/ios/ObjCRuntime"
	.asciz "/Users/shuoyang/Projects/lelaozu-Iphone/lelaozu-Iphone/JPush/obj/Debug/ios/JPush"

	.byte 0
	.asciz "Messaging.g.cs"

	.byte 1,0,0
	.asciz "APService.g.cs"

	.byte 2,0,0
	.asciz "<unknown>"

	.byte 0,0,0,0
Ldebug_line_header_end:
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad ApiDefinition_Messaging__cctor

	.byte 4,1,1,10,3,37,2,48,1,2,128,1,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService__ctor

	.byte 4,2,1,10,3,47,2,56,1,3,1,2,60,1,243,3,1,2,192,1,1,3,1,2,220,0,1,3,1,2,196,1
	.byte 1,3,1,2,36,1,3,1,2,196,1,1,243,2,192,0,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService__ctor_Foundation_NSObjectFlag

	.byte 4,2,1,10,3,59,2,60,1,3,1,2,48,1,243,3,1,2,192,1,1,2,48,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService__ctor_intptr

	.byte 4,2,1,10,3,194,0,2,60,1,3,1,2,48,1,243,3,1,2,192,1,1,2,48,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_get_ClassHandle

	.byte 4,2,1,10,3,42,2,60,1,2,252,0,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_BeginLogPageView_string_int

	.byte 4,2,1,10,3,202,0,2,192,0,1,8,229,8,117,3,1,2,216,0,1,3,2,2,204,0,1,3,1,2,136,1
	.byte 1,3,2,2,48,1,2,48,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_ClearAllLocalNotifications

	.byte 4,2,1,10,3,215,0,2,48,1,8,229,3,1,2,224,0,1,2,44,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_CrashLogON

	.byte 4,2,1,10,3,222,0,2,48,1,8,229,3,1,2,224,0,1,2,44,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_DeleteLocalNotification_UIKit_UILocalNotification

	.byte 4,2,1,10,3,229,0,2,56,1,8,229,8,117,3,1,2,216,0,1,3,1,2,152,1,1,2,48,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_DeleteLocalNotificationWithIdentifierKey_string

	.byte 4,2,1,10,3,238,0,2,60,1,8,229,8,117,3,1,2,216,0,1,3,2,2,204,0,1,3,1,2,252,0,1
	.byte 3,2,2,48,1,2,48,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_FilterValidTags_Foundation_NSSet

	.byte 4,2,1,10,3,251,0,2,60,1,8,229,8,117,3,1,2,216,0,1,3,1,2,224,1,1,2,56,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_FindLocalNotificationWithIdentifier_string

	.byte 4,2,1,10,3,132,1,2,200,0,1,8,229,8,117,3,1,2,216,0,1,3,3,2,204,0,1,3,1,2,192,1
	.byte 1,3,2,2,48,1,8,117,2,60,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_HandleRemoteNotification_Foundation_NSDictionary

	.byte 4,2,1,10,3,147,1,2,56,1,8,229,8,117,3,1,2,216,0,1,3,1,2,152,1,1,2,48,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_RegisterDeviceToken_Foundation_NSData

	.byte 4,2,1,10,3,156,1,2,56,1,8,229,8,117,3,1,2,216,0,1,3,1,2,152,1,1,2,48,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_RegisterForRemoteNotificationTypes_System_nuint_Foundation_NSSet

	.byte 4,2,1,10,3,165,1,2,196,0,1,8,229,3,1,2,252,1,1,2,56,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_ResetBadge

	.byte 4,2,1,10,3,172,1,2,48,1,8,229,3,1,2,224,0,1,2,44,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_SetAlias_string_ObjCRuntime_Selector_Foundation_NSObject

	.byte 4,2,1,10,3,179,1,2,208,0,1,8,229,3,2,2,208,0,1,3,1,2,220,3,1,3,2,2,44,1,2,60
	.byte 1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_SetBadge_System_nint

	.byte 4,2,1,10,3,190,1,2,60,1,8,229,3,1,2,160,1,1,2,56,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_SetDebugMode

	.byte 4,2,1,10,3,197,1,2,48,1,8,229,3,1,2,224,0,1,2,44,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_SetLatitude_double_double

	.byte 4,2,1,10,3,204,1,2,56,1,8,229,3,1,2,136,1,1,2,44,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_SetLocalNotification_Foundation_NSDate_string_int_string_string_Foundation_NSDictionary_string

	.byte 4,2,1,10,3,211,1,2,132,1,1,8,229,8,117,3,1,2,216,0,1,8,117,3,1,2,216,0,1,8,117,3
	.byte 1,2,216,0,1,8,117,3,1,2,216,0,1,8,117,3,1,2,216,0,1,3,1,2,200,0,1,3,1,2,200,0
	.byte 1,3,1,2,200,0,1,3,3,2,204,0,1,3,1,2,228,2,1,3,1,2,48,1,3,1,2,48,1,3,1,2
	.byte 48,1,3,2,2,48,1,8,117,2,192,0,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_SetLocalNotification_Foundation_NSDate_string_int_string_string_Foundation_NSDictionary_string_CoreLocation_CLRegion_bool_string

	.byte 4,2,1,10,3,240,1,2,148,1,1,8,229,8,117,3,1,2,216,0,1,8,117,3,1,2,216,0,1,8,117,3
	.byte 1,2,216,0,1,8,117,3,1,2,216,0,1,8,117,3,1,2,216,0,1,8,117,3,1,2,216,0,1,8,117,3
	.byte 1,2,216,0,1,8,117,3,1,2,216,0,1,3,1,2,200,0,1,3,1,2,204,0,1,3,1,2,204,0,1,3
	.byte 1,2,204,0,1,3,3,2,204,0,1,3,1,2,216,3,1,3,1,2,48,1,3,1,2,48,1,3,1,2,48,1
	.byte 3,1,2,48,1,3,2,2,48,1,8,117,2,200,0,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_SetLocation_CoreLocation_CLLocation

	.byte 4,2,1,10,3,149,2,2,56,1,8,229,8,117,3,1,2,216,0,1,3,1,2,152,1,1,2,48,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_SetLogOFF

	.byte 4,2,1,10,3,158,2,2,48,1,8,229,3,1,2,224,0,1,2,44,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_SetTagsWithObject_Foundation_NSSet_string_ObjCRuntime_Selector_Foundation_NSObject

	.byte 4,2,1,10,3,165,2,2,212,0,1,8,229,3,2,2,204,0,1,3,1,2,248,4,1,3,2,2,44,1,2,60
	.byte 1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_SetTagsWithTarger_Foundation_NSSet_string_ObjCRuntime_Selector_Foundation_NSObject

	.byte 4,2,1,10,3,176,2,2,212,0,1,8,229,3,2,2,204,0,1,3,1,2,248,4,1,3,2,2,44,1,2,60
	.byte 1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_SetTagsWithTarget_Foundation_NSSet_ObjCRuntime_Selector_Foundation_NSObject

	.byte 4,2,1,10,3,187,2,2,204,0,1,8,229,3,1,2,188,4,1,2,60,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_SetupWithOption_Foundation_NSDictionary

	.byte 4,2,1,10,3,194,2,2,60,1,8,229,3,1,2,228,1,1,2,52,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_ShowLocalNotificationAtFront_UIKit_UILocalNotification_string

	.byte 4,2,1,10,3,201,2,2,196,0,1,8,229,8,117,3,1,2,216,0,1,8,117,3,1,2,216,0,1,3,2,2
	.byte 200,0,1,3,1,2,180,1,1,3,2,2,48,1,2,52,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_StartLogPageView_string

	.byte 4,2,1,10,3,216,2,2,60,1,8,229,8,117,3,1,2,216,0,1,3,2,2,204,0,1,3,1,2,252,0,1
	.byte 3,2,2,48,1,2,48,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_StopLogPageView_string

	.byte 4,2,1,10,3,229,2,2,60,1,8,229,8,117,3,1,2,216,0,1,3,2,2,204,0,1,3,1,2,252,0,1
	.byte 3,2,2,48,1,2,48,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService_get_RegistrationID

	.byte 4,2,1,10,3,242,2,2,56,1,8,229,3,1,2,156,1,1,2,56,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,9,2
	.quad JPush_APService__cctor

	.byte 4,2,1,10,3,40,2,48,1,2,244,0,1,0,1,1,0,1,1
Ldebug_line_end:
.text
	.align 3
mem_end:

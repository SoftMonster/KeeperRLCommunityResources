﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("KRLDeveloperNS.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to GNU GENERAL PUBLIC LICENSE
        '''                       Version 2, June 1991
        '''
        ''' Copyright (C) 1989, 1991 Free Software Foundation, Inc., &lt;http://fsf.org/&gt;
        ''' 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA
        ''' Everyone is permitted to copy and distribute verbatim copies
        ''' of this license document, but changing it is not allowed.
        '''
        '''                            Preamble
        '''
        '''  The licenses for most software are designed to take away your
        '''freedom to share and change it.  By contrast, the GNU General Public        ''' [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property COPYING() As String
            Get
                Return ResourceManager.GetString("COPYING", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to #pragma once
        '''
        '''#include &quot;util.h&quot;
        '''#include &quot;effect.h&quot;
        '''#include &quot;creature_id.h&quot;
        '''#include &quot;furniture_type.h&quot;
        '''#include &quot;destroy_action.h&quot;
        '''#include &quot;intrinsic_attack.h&quot;
        '''#include &quot;spell_id.h&quot;
        '''#include &quot;sound.h&quot;
        '''#include &quot;color.h&quot;
        '''#include &quot;fx_info.h&quot;
        '''#include &quot;workshop_type.h&quot;
        '''#include &quot;creature_predicate.h&quot;
        '''
        '''#define SIMPLE_EFFECT(Name) \
        '''  struct Name { \
        '''    SERIALIZE_EMPTY()\
        '''  }
        '''
        '''namespace Effects {
        '''SIMPLE_EFFECT(Escape);
        '''SIMPLE_EFFECT(Teleport);
        '''SIMPLE_EFFECT(Jump);
        '''struct Heal {
        '''  He [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property effect_type() As String
            Get
                Return ResourceManager.GetString("effect_type", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property monster_generator_instructions() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("monster_generator_instructions", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property monster_keeper() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("monster_keeper", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property monster_template() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("monster_template", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property monster_template_attacks() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("monster_template_attacks", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property monster_template_redundancy() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("monster_template_redundancy", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to [[File:¬ViewId¬.png|100px|link=]]
        '''
        '''= Base Stats =
        '''*Gender:¬gender¬
        '''*Alignment:¬hatedByEffect¬
        '''*Body:¬Body¬
        '''*Attributes:¬attr¬
        '''*Skills:¬Skills¬
        '''*Training Ability:¬MaxLevelIncrease¬
        '''*Spell Schools:¬SpellSchools¬
        '''*Spells: ¬Spells¬
        '''*Permanent Effects:¬permanentEffects¬
        '''
        '''[[Category: Creatures]]
        '''.
        '''</summary>
        Friend ReadOnly Property WikiCreatureTemplate() As String
            Get
                Return ResourceManager.GetString("WikiCreatureTemplate", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to type = Builtin |
        '''SMALL_VILLAGE|Small village
        '''tribe = HUMAN|*Tribal Loyalty: Humanity
        '''tribe = |*Tribal Loyalty:
        '''MINETOWN|Mine Town
        '''TOWN|Town
        '''MONSTER|None
        '''race =|*Race:
        '''inhabitants|*Inhabitants
        '''DUNGEON|Dungeon
        '''locationNameGen = TOWN |*Location Named as: TOWN 
        '''outsideFeatures|*Outside features
        '''dungeonOutside|Dungeon surroundings
        '''roomFurniture|Standard Furniture
        '''buildingId|*Building Style
        '''furniture|Furniture
        '''maxPopulation =|*Max Population:
        '''CAVE|Cave
        '''= |:
        '''&lt;Stats&gt;|= Stats =.
        '''</summary>
        Friend ReadOnly Property WikiEnemiesReplacements() As String
            Get
                Return ResourceManager.GetString("WikiEnemiesReplacements", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;Stats&gt;
        '''*Settlement:¬settlement¬
        '''*Configuration:¬config¬
        '''*Immigration:¬immigrants¬
        '''*AI:¬behaviour¬
        '''*Notable discovery:¬discoverable¬
        '''*Supplanted enemies:¬createOnBones¬
        '''*Z-level connections:¬levelConnection¬
        '''*Biomes:¬biomes¬
        '''*Other enemy:¬otherEnemy¬
        '''
        '''[[Category: Tribes]]
        '''.
        '''</summary>
        Friend ReadOnly Property WikiEnemiesTemplate() As String
            Get
                Return ResourceManager.GetString("WikiEnemiesTemplate", resourceCulture)
            End Get
        End Property
    End Module
End Namespace

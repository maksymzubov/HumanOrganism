using System;
using System.Collections.Generic;
using System.Text;

namespace HumanOrganism.Anatomy.Bones
{
    public enum BoneType
    {
        // Skull
        Frontal,
        Parietal,
        Temporal,
        Occipital,
        Sphenoid,
        Ethmoid,

        // Facial bones
        Maxilla,
        Mandible,
        Zygomatic,
        Nasal,
        Lacrimal,
        Palatine,
        InferiorNasalConcha,
        Vomer,

        // Auditory ossicles
        Malleus,
        Incus,
        Stapes,

        // Other axial bones
        Hyoid,
        CervicalVertebra,
        ThoracicVertebra,
        LumbarVertebra,
        Sacrum,
        Coccyx,
        Sternum,
        Rib,

        // Shoulder girdle
        Clavicle,
        Scapula,

        // Upper limb
        Humerus,
        Radius,
        Ulna,

        // Hand
        Scaphoid,
        Lunate,
        Triquetrum,
        Pisiform,
        Trapezium,
        Trapezoid,
        Capitate,
        Hamate,
        Metacarpal,
        HandPhalanx,

        // Pelvis
        HipBone,
        Ilium,
        Ischium,
        Pubis,

        // Lower limb
        Femur,
        Patella,
        Tibia,
        Fibula,

        // Foot
        Talus,
        Calcaneus,
        Navicular,
        MedialCuneiform,
        IntermediateCuneiform,
        LateralCuneiform,
        Cuboid,
        Metatarsal,
        FootPhalanx
    }
}